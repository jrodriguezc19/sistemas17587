using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Almacen
{
    public class Categoria
    {

        public int idCategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Error minimo 3 caracteres")]
        public string Nombre { get; set; }
        [StringLength(250)]
        public string Descripcion { get; set; }

        public bool Condicion { get; set; }

        public List<Articulo> Articulos { get; set; }

    }
}