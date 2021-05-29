using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Compras;
using Umg.Entidades.Ventas;

namespace Umg.Entidades.Usuarios
{
   
    
   public class Persona
   {
        public int IdPersona { get; set; }

        public string TipoPersona { get; set; }

        public string Nombre { get; set; }

        public string TipoDocumento { get; set; }

        public string NumDocumento { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }


        public List<Ingreso> Ingresos { get; set; }
        
        public List<Venta> Ventas { get; set; }

    }

}
