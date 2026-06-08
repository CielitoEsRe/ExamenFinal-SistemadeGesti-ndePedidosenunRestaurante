using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_SistemadeGestióndePedidosenunRestaurante.Models
{
    public class PlatoFuerte : Producto
    {
        private string tipoCarne;
        private string acompanamiento;

        public string TipoCarne
        {
            get
            {
                return tipoCarne;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El tipo de carne no puede estar vacío.");
                }

                tipoCarne = value.Trim();
            }
        }

        public string Acompanamiento
        {
            get
            {
                return acompanamiento;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El acompañamiento no puede estar vacío.");
                }

                acompanamiento = value.Trim();
            }
        }

        public override string TipoProducto
        {
            get
            {
                return "PlatoFuerte";
            }
        }

        public PlatoFuerte(
            string codigo,
            string nombre,
            decimal precioBase,
            string tipoCarne,
            string acompanamiento
        )
            : base(codigo, nombre, precioBase)
        {
            this.tipoCarne = "";
            this.acompanamiento = "";

            TipoCarne = tipoCarne;
            Acompanamiento = acompanamiento;
        }

        public override string ObtenerDetalle()
        {
            return "Carne: " + TipoCarne + " - Acompañamiento: " + Acompanamiento;
        }
    }
}
