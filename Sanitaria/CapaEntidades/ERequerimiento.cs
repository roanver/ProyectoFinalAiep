using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ERequerimiento
    {
        public int Id_requerimiento { get; set; }   
        public int Id_usuario { get; set; }
        public string Responsable { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }

    }
}
