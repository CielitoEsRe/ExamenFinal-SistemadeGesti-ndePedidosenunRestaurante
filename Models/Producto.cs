using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_SistemadeGestióndePedidosenunRestaurante.Models
{
    public abstract class Producto
    {
        private string codigo;
        private string nombre;
        private decimal precioBase;

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El código no puede estar vacío.");
                }

                codigo = value.Trim();
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }

                nombre = value.Trim();
            }
        }

        public decimal PrecioBase
        {
            get
            {
                return precioBase;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El precio debe ser mayor que 0.");
                }

                precioBase = value;
            }
        }

        public abstract string TipoProducto { get; }

        public Producto(string codigo, string nombre, decimal precioBase)
        {
            this.codigo = "";
            this.nombre = "";

            Codigo = codigo;
            Nombre = nombre;
            PrecioBase = precioBase;
        }

        public abstract string ObtenerDetalle();
    }
}

