using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaEntidades; 
namespace CapaDatos


{
    public class DUsuario
    {
   
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

       

        public DataTable dLogin(EUsuario obje)
        {
            SqlCommand cmd = new SqlCommand("splogin_usuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.Nombre);
            cmd.Parameters.AddWithValue("@contraseña", obje.Contraseña);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable1 = new DataTable();
            da.Fill(dtable1);
            return dtable1;
        }


    }

}


