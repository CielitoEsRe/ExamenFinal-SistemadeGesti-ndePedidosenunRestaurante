using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_SistemadeGestióndePedidosenunRestaurante.Models
{
    public class Bebida : Producto
    {
        private int volumenMl;
        private string tipoBebida;

        public int VolumenMl
        {
            get
            {
                return volumenMl;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El volumen debe ser mayor que 0.");
                }

                volumenMl = value;
            }
        }

        public string TipoBebida
        {
            get
            {
                return tipoBebida;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El tipo de bebida no puede estar vacío.");
                }

                tipoBebida = value.Trim();
            }
        }

        public override string TipoProducto
        {
            get
            {
                return "Bebida";
            }
        }

        public Bebida(string codigo, string nombre, decimal precioBase, int volumenMl, string tipoBebida)
            : base(codigo, nombre, precioBase)
        {
            this.tipoBebida = "";

            VolumenMl = volumenMl;
            TipoBebida = tipoBebida;
        }

        public override string ObtenerDetalle()
        {
            return TipoBebida + " - " + VolumenMl + " ml";
        }
    }

}

