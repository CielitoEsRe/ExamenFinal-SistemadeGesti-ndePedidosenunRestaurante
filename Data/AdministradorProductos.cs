using ExamenFinal_SistemadeGestióndePedidosenunRestaurante.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using ExamenFinal_SistemadeGestióndePedidosenunRestaurante.Data;

namespace RestaurantePedidosWinForms.Datos
{
    public class AdministradorProductos
    {
        private readonly string rutaArchivo;

        public AdministradorProductos()
        {
            rutaArchivo = Path.Combine(Application.StartupPath, "productos.json");
        }

        public List<Producto> CargarProductos()
        {
            if (!File.Exists(rutaArchivo))
            {
                return new List<Producto>();
            }

            string json = File.ReadAllText(rutaArchivo);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<Producto>();
            }

            List<ArchivoProducto> datos = JsonConvert.DeserializeObject<List<ArchivoProducto>>(json);

            if (datos == null)
            {
                return new List<Producto>();
            }

            List<Producto> productos = new List<Producto>();

            foreach (ArchivoProducto item in datos)
            {
                try
                {
                    switch (item.TipoProducto)
                    {
                        case "Bebida":
                            productos.Add(new Bebida(
                                item.Codigo,
                                item.Nombre,
                                item.PrecioBase,
                                item.VolumenMl,
                                item.TipoBebida
                            ));
                            break;

                        case "PlatoFuerte":
                            productos.Add(new PlatoFuerte(
                                item.Codigo,
                                item.Nombre,
                                item.PrecioBase,
                                item.TipoCarne,
                                item.Acompanamiento
                            ));
                            break;

                        case "Postre":
                            productos.Add(new Postre(
                                item.Codigo,
                                item.Nombre,
                                item.PrecioBase,
                                item.ContieneAzucar,
                                item.Porcion
                            ));
                            break;
                    }
                }
                catch
                {
                  
                }
            }

            return productos;
        }

        public void GuardarProductos(List<Producto> productos)
        {
            List<ArchivoProducto> datos = productos.Select(ConvertirAJSON).ToList();

            string json = JsonConvert.SerializeObject(datos, Formatting.Indented);

            File.WriteAllText(rutaArchivo, json);
        }

        private ArchivoProducto ConvertirAJSON(Producto producto)
        {
            ArchivoProducto productoJSON = new ArchivoProducto();

            productoJSON.TipoProducto = producto.TipoProducto;
            productoJSON.Codigo = producto.Codigo;
            productoJSON.Nombre = producto.Nombre;
            productoJSON.PrecioBase = producto.PrecioBase;

            if (producto is Bebida)
            {
                Bebida bebida = (Bebida)producto;

                productoJSON.VolumenMl = bebida.VolumenMl;
                productoJSON.TipoBebida = bebida.TipoBebida;
            }
            else if (producto is PlatoFuerte)
            {
                PlatoFuerte plato = (PlatoFuerte)producto;

                productoJSON.TipoCarne = plato.TipoCarne;
                productoJSON.Acompanamiento = plato.Acompanamiento;
            }
            else if (producto is Postre)
            {
                Postre postre = (Postre)producto;

                productoJSON.ContieneAzucar = postre.ContieneAzucar;
                productoJSON.Porcion = postre.Porcion;
            }

            return productoJSON;
        }
    }
}