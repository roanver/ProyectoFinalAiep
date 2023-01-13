using CapaDatos;
using CapaEntidades;


namespace CapaNegocio
{
    public class NRequerimiento
    {

        DRequerimiento objDR = new DRequerimiento();

        //Funcion Insertar en Capa negocio llama a la funcion insertar de la capa dato

        public int Insertar(ERequerimiento Obj)
        {
            
            return objDR.Insertar(Obj); 
        }
    }
}
