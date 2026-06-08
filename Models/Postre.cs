using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_SistemadeGestióndePedidosenunRestaurante.Models
{
    public class Postre : Producto
    {
        private string contieneAzucar;
        private string porcion;

        public string ContieneAzucar
        {
            get => contieneAzucar;
            set
            {
                if (value != "Sí" && value != "No")
                    throw new ArgumentException("Debe indicar si contiene azúcar: Sí o No.");

                contieneAzucar = value;
            }
        }

        public string Porcion
        {
            get => porcion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La porción no puede estar vacía.");

                porcion = value.Trim();
            }
        }

        public override string TipoProducto => "Postre";

        public Postre(
            string codigo,
            string nombre,
            decimal precioBase,
            string contieneAzucar,
            string porcion
        )
            : base(codigo, nombre, precioBase)
        {
            this.contieneAzucar = "";
            this.porcion = "";

            ContieneAzucar = contieneAzucar;
            Porcion = porcion;
        }

        public override string ObtenerDetalle()
        {
            return $"Azúcar: {ContieneAzucar} - Porción: {Porcion}";
        }
    }

}
