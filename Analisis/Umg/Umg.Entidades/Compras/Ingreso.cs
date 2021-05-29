using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;
using Umg.Entidades.Ventas;

namespace Umg.Entidades.Compras
{
    public class Ingreso
    {
        public int Idingreso { get; set; }

        public string TipoComprobante { get; set; }

        public  string SerieComprobante { get; set; }

        public string NumComprobante { get; set; }

        public DateTime FechaHora { get; set; }

        public Decimal Impuesto { get; set; }

        public string Estado { get; set; }

        public decimal Total { get; set; }


        //concatenacion de ingreso a usuario//
         public List<Usuario> Usuarios { get; set; }

        //concatenacion ingreso con persona//
         public List<Persona> personas { get; set; }

         public List<DetalleIngreso> DetalleIngresos { get; set; }

    }
}
