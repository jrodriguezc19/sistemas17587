using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Usuarios
{
   public class Telefono
    {
        public int idTelefono { get; set; }
        public int idPersona { get; set; }

        public string telefonoPersonal { get; set; }

        public string telefonoResidencial { get; set; }

        public string telefonoLaboral { get; set; }

        //concatenar telefono usuario//
       public List<Usuario> Usuarios { get; set; }



    }

}
