using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Entidades.Ventas
{
    public class Venta
    {
        public  int idVenta { get; set; }

        public  string TipoComprobante { get; set; }

        public string serieComprobante { get; set; }

        public string NumComprobante { get; set; }

        public DateTime FechaHora { get; set; }

        public decimal Impuesto { get; set; }

        public decimal total { get; set; }

        public string estado { get; set; }

        //recibe de detalle venta
        List<DetalleVenta> DetalleVentas { get; set; }

        //relacion venta con tabla personas //

        public List<Persona> Personas { get; set; }
        
        //relacion de venta con tabla usuari//o
        public List<Usuario> Usuarios { get; set; }


    }
}
