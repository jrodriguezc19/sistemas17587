using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Umg.Entidades.Ventas;

namespace Umg.Entidades.Almacen
{
   public class Articulo
    {

        public int idArticulo { get; set; }
        
        public string codigo { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]

        public string nombre { get; set; }
        [Required]
        public  decimal precioVenta { get; set; }
        [Required]
        public int stock { get; set; }

        public string descripcion { get; set; }

        public  bool condicion { get; set; }

        //recibe de detalleVenta//
        public List<DetalleVenta> DetalleVentas { get; set; }

        public List<DetalleIngreso> DetalleIngresos { get; set; }

        //relacion de tablas categoria//
        public List<Categoria> Categorias { get; set; }

        
      

    }

}
