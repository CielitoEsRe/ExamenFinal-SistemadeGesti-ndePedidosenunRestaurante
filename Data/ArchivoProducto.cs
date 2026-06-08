using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal_SistemadeGestióndePedidosenunRestaurante.Data
{
    public class ArchivoProducto
    {

        public string TipoProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioBase { get; set; }

        public int VolumenMl { get; set; }
        public string TipoBebida { get; set; }

        public string TipoCarne { get; set; }
        public string Acompanamiento { get; set; }

        public string ContieneAzucar { get; set; }
        public string Porcion { get; set; }

        public ArchivoProducto()
        {
            TipoProducto = "";
            Codigo = "";
            Nombre = "";
            PrecioBase = 0;

            VolumenMl = 0;
            TipoBebida = "";

            TipoCarne = "";
            Acompanamiento = "";

            ContieneAzucar = "";
            Porcion = "";
        }
    }
}
