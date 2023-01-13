using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EUsuario
    {
        private int _id_usuario;
        private string _nombre;
        private string _apellido;
        private string _contraseña;
        private int _id_rol;

        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public int Id_rol { get => _id_rol; set => _id_rol = value; }
    }
}
