using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Usuarios
{
    public class Rol
    {

        public  int idRol { get; set; }

        public  string nombre { get; set; }

        public  string descipcion { get; set; }

        public bool condicion { get; set; }
        
        public List<Usuario> Usuarios { get; set; }



    }
}
