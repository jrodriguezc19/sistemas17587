using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Almacen;
using Umg.Entidades.Compras;

namespace Umg.Entidades.Ventas
{
    public class DetalleIngreso
    
    {
        public int IdDetalleIngreso { get; set; }

        public int idIngreso { get; set; }

        public int idArticulo { get; set; }

        public int Cantidad { get; set; }

        public String PrecioDetalle { get; set; }


        //relacion venta con tabla personas //

        public List<Ingreso> Ingresos { get; set; }

        //relacion de venta con tabla usuari//o
        public List<Articulo> Articulos { get; set; }



    }
}