using ExamenFinal_SistemadeGestióndePedidosenunRestaurante.Data;
using ExamenFinal_SistemadeGestióndePedidosenunRestaurante.Models;
using RestaurantePedidosWinForms.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal_SistemadeGestióndePedidosenunRestaurante
{
    public partial class Form1 : Form
    {
        private List<Producto> productos = new List<Producto>();
        private AdministradorProductos administrador = new AdministradorProductos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeleccionarPrimerElementoCombos();

            productos = administrador.CargarProductos();

            MostrarProductos(productos);
        }

        private void SeleccionarPrimerElementoCombos()
        {
            if (comboBoxProducto.Items.Count > 0)
                comboBoxProducto.SelectedIndex = 0;

            if (comboBoxBebida.Items.Count > 0)
                comboBoxBebida.SelectedIndex = 0;

            if (comboBoxTipoCarne.Items.Count > 0)
                comboBoxTipoCarne.SelectedIndex = 0;

            if (comboBoxAcomp.Items.Count > 0)
                comboBoxAcomp.SelectedIndex = 0;

            if (comboBoxAzucar.Items.Count > 0)
                comboBoxAzucar.SelectedIndex = 0;

            if (comboBoxPorcion.Items.Count > 0)
                comboBoxPorcion.SelectedIndex = 0;

            if (comboBoxBusqueda.Items.Count > 0)
                comboBoxBusqueda.SelectedIndex = 0;
        }

        private void buttonIrTipo_Click(object sender, EventArgs e)
        {
            if (comboBoxProducto.Text == "Bebida")
            {
                tabControl1.SelectedTab = tabBebida;
            }
            else if (comboBoxProducto.Text == "PlatoFuerte")
            {
                tabControl1.SelectedTab = tabPlatoFuerte;
            }
            else if (comboBoxProducto.Text == "Postre")
            {
                tabControl1.SelectedTab = tabPostre;
            }
        }

        private void buttonAgregarbebida_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarProductoGeneral();
                ValidarBebida();

                string codigo = textBoxCodigo.Text.Trim();

                if (CodigoExiste(codigo))
                {
                    MessageBox.Show("Ya existe un producto con ese código.");
                    return;
                }

                Bebida bebida = new Bebida(
                    textBoxCodigo.Text.Trim(),
                    textBoxNomb.Text.Trim(),
                    decimal.Parse(textBoxPrecio.Text),
                    int.Parse(textBoxVolumen.Text),
                    comboBoxBebida.Text
                );

                productos.Add(bebida);

                administrador.GuardarProductos(productos);

                MostrarProductos(productos);

                LimpiarCampos();

                MessageBox.Show("Bebida agregada correctamente.");

                tabControl1.SelectedTab = tabListado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAgregarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarProductoGeneral();
                ValidarPlato();

                string codigo = textBoxCodigo.Text.Trim();

                if (CodigoExiste(codigo))
                {
                    MessageBox.Show("Ya existe un producto con ese código.");
                    return;
                }

                PlatoFuerte plato = new PlatoFuerte(
                    textBoxCodigo.Text.Trim(),
                    textBoxNomb.Text.Trim(),
                    decimal.Parse(textBoxPrecio.Text),
                    comboBoxTipoCarne.Text,
                    comboBoxAcomp.Text
                );

                productos.Add(plato);

                administrador.GuardarProductos(productos);

                MostrarProductos(productos);

                LimpiarCampos();

                MessageBox.Show("Plato fuerte agregado correctamente.");

                tabControl1.SelectedTab = tabListado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAgregarPostre_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarProductoGeneral();
                ValidarPostre();

                string codigo = textBoxCodigo.Text.Trim();

                if (CodigoExiste(codigo))
                {
                    MessageBox.Show("Ya existe un producto con ese código.");
                    return;
                }

                Postre postre = new Postre(
                    textBoxCodigo.Text.Trim(),
                    textBoxNomb.Text.Trim(),
                    decimal.Parse(textBoxPrecio.Text),
                    comboBoxAzucar.Text,
                    comboBoxPorcion.Text
                );

                productos.Add(postre);

                administrador.GuardarProductos(productos);

                MostrarProductos(productos);

                LimpiarCampos();

                MessageBox.Show("Postre agregado correctamente.");

                tabControl1.SelectedTab = tabListado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ValidarProductoGeneral()
        {
            if (textBoxCodigo.Text.Trim() == "")
            {
                throw new Exception("Debe ingresar el código del producto.");
            }

            if (textBoxNomb.Text.Trim() == "")
            {
                throw new Exception("Debe ingresar el nombre del producto.");
            }

            decimal precio;

            if (!decimal.TryParse(textBoxPrecio.Text, out precio))
            {
                throw new Exception("El precio debe ser un número.");
            }

            if (precio <= 0)
            {
                throw new Exception("El precio debe ser mayor que 0.");
            }

            if (comboBoxProducto.Text == "")
            {
                throw new Exception("Debe seleccionar el tipo de producto.");
            }
        }

        private void ValidarBebida()
        {
            int volumen;

            if (!int.TryParse(textBoxVolumen.Text, out volumen))
            {
                throw new Exception("El volumen debe ser un número entero.");
            }

            if (volumen <= 0)
            {
                throw new Exception("El volumen debe ser mayor que 0.");
            }

            if (comboBoxBebida.Text == "")
            {
                throw new Exception("Debe seleccionar el tipo de bebida.");
            }
        }

        private void ValidarPlato()
        {
            if (comboBoxTipoCarne.Text == "")
            {
                throw new Exception("Debe seleccionar el tipo de carne.");
            }

            if (comboBoxAcomp.Text == "")
            {
                throw new Exception("Debe seleccionar el acompañamiento.");
            }
        }

        private void ValidarPostre()
        {
            if (comboBoxAzucar.Text == "")
            {
                throw new Exception("Debe seleccionar si contiene azúcar.");
            }

            if (comboBoxPorcion.Text == "")
            {
                throw new Exception("Debe seleccionar la porción.");
            }
        }

        private bool CodigoExiste(string codigo)
        {
            return productos.Any(
                p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase)
            );
        }

        private void MostrarProductos(List<Producto> lista)
        {
            dataGridViewMostrarProd.DataSource = null;

            var datos = lista.Select(p => new
            {
                Codigo = p.Codigo,
                Nombre = p.Nombre,
                Tipo = p.TipoProducto,
                Precio = p.PrecioBase,
                Detalle = p.ObtenerDetalle()
            }).ToList();

            dataGridViewMostrarProd.DataSource = datos;

            labelTotal.Text = "Total de productos: " + productos.Count;
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            MostrarProductos(productos);

            tabControl1.SelectedTab = tabListado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = comboBoxBusqueda.Text;
            string texto = textBoxBusqueda.Text.Trim().ToLower();

            if (texto == "")
            {
                MessageBox.Show("Ingrese un texto para buscar.");
                return;
            }

            List<Producto> resultados = new List<Producto>();

            if (criterio == "Código")
            {
                resultados = productos
                    .Where(p => p.Codigo.ToLower().Contains(texto))
                    .ToList();
            }
            else if (criterio == "Nombre")
            {
                resultados = productos
                    .Where(p => p.Nombre.ToLower().Contains(texto))
                    .ToList();
            }
            else if (criterio == "Tipo de producto")
            {
                resultados = productos
                    .Where(p => p.TipoProducto.ToLower().Contains(texto))
                    .ToList();
            }

            MostrarResultadosBusqueda(resultados);

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron productos.");
            }
        }

        private void MostrarResultadosBusqueda(List<Producto> lista)
        {
            dataGridViewBuscar.DataSource = null;

            var datos = lista.Select(p => new
            {
                Codigo = p.Codigo,
                Nombre = p.Nombre,
                Tipo = p.TipoProducto,
                Precio = p.PrecioBase,
                Detalle = p.ObtenerDetalle()
            }).ToList();

            dataGridViewBuscar.DataSource = datos;
        }

        private void LimpiarCampos()
        {
            textBoxCodigo.Clear();
            textBoxNomb.Clear();
            textBoxPrecio.Clear();

            textBoxVolumen.Clear();

            if (comboBoxProducto.Items.Count > 0)
                comboBoxProducto.SelectedIndex = 0;

            if (comboBoxBebida.Items.Count > 0)
                comboBoxBebida.SelectedIndex = 0;

            if (comboBoxTipoCarne.Items.Count > 0)
                comboBoxTipoCarne.SelectedIndex = 0;

            if (comboBoxAcomp.Items.Count > 0)
                comboBoxAcomp.SelectedIndex = 0;

            if (comboBoxAzucar.Items.Count > 0)
                comboBoxAzucar.SelectedIndex = 0;

            if (comboBoxPorcion.Items.Count > 0)
                comboBoxPorcion.SelectedIndex = 0;

            textBoxBusqueda.Clear();

            textBoxCodigo.Focus();

            tabControl1.SelectedTab = tabRegistro;
        }
    }
}

