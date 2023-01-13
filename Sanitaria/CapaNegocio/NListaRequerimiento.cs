using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocio
{
    public class NListaRequerimiento
    {
        DListaRequerimiento lista = new DListaRequerimiento();

        public DataTable dt()
        {
            return lista.MostrarReque(); 

        }
        public DataTable listar(ERequerimiento er)
        {
            return lista.dataTableReque(er);
        }

        public DataTable CambioEstado(ERequerimiento E)
        {
            return lista.CambioEstado(E);
        }
        public DataTable eliminar(ERequerimiento erq)
        {
            return lista.eliminarRequ(erq);
        }
    }

}
