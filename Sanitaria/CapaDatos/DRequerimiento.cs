using CapaEntidades;
using Dapper;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data; 

namespace CapaDatos
{
    public class DRequerimiento
    {
        
        private string ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ToString();

        public int Insertar(ERequerimiento Requerimiento)
        {
     
            using (SqlConnection cn = new SqlConnection(ConnectionString)) 
            {

                cn.Open();
                const string cadena = "insert into requerimiento(id_usuario, responsable, tipo, descripcion, estado, prioridad) values(@id_usuario, @responsable, @tipo, @descripcion, @estado, @prioridad)";
                
                
                    var parameters = new DynamicParameters();

                    parameters.Add("@id_usuario", Requerimiento.Id_usuario, DbType.Int32);
                    parameters.Add("@responsable", Requerimiento.Responsable, DbType.String);
                    parameters.Add("@tipo", Requerimiento.Tipo, DbType.String);
                    parameters.Add("@descripcion", Requerimiento.Descripcion, DbType.String);
                    parameters.Add("@estado", Requerimiento.Estado, DbType.String);
                    parameters.Add("@prioridad", Requerimiento.Prioridad, DbType.String);

                    return cn.Execute(cadena, parameters, commandType: CommandType.Text);

             

            }
               
            
        
             
        }
       
    }
}
