using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Almacen;

namespace Umg.Entidades.Ventas
{
   public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }

        public int cantidad { get; set; }

        public decimal PrecioDetalleVenta { get; set; }

        public decimal Descuento { get; set; }

        public List<Venta> Ventas { get; set; }

        public List<Articulo> Articulos { get; set; }



    }
}
