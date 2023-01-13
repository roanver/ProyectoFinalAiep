using CapaDatos;
using CapaEntidades;
using System.Data;


namespace CapaNegocio
{
    public class NUsuario
    {
       DUsuario objDU = new DUsuario();

        public DataTable nLogin(EUsuario obje)
        {
  
            return objDU.dLogin(obje);
        }
       

       
    }

    
}
