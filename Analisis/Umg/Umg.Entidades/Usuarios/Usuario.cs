using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Compras;
using Umg.Entidades.Ventas;

namespace Umg.Entidades.Usuarios
{
    public class Usuario
    {
        public int idusuario { get; set; }

        public string nombre { get; set; }

        public string tipodocumento { get; set; }

        public string numdocumentos { get; set; }

        public string direccion  { get; set; }

        public string telefono { get; set; }

        public string Email { get; set; }

        public byte password_hash { get; set; }

        public byte Password_sal { get; set; }

        public bool  condicion { get; set; }

        //recibe de tabla ingreso//
        public List<Ingreso> Ingresos { get; set; }

        public List<Venta> Ventas { get; set; }

        //Conexion de usuario con tabla Role //

        public List<Rol> Roles { get; set; }

        


    }
}
