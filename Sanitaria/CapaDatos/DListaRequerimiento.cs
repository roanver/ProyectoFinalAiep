using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DListaRequerimiento
    {
        
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable MostrarReque()
        {
            DataTable lista = new DataTable();
            //cn.Open();
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.Connection = cn;
            Sqlcmd.CommandText = "splistar_requerimiento";
            Sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqladapter = new SqlDataAdapter(Sqlcmd);
            sqladapter.Fill(lista);
            //cn.Close();
            return lista;

            
        }

        public DataTable dataTableReque(ERequerimiento er)
        {

            DataTable list = new DataTable();
            cn.Open();
            SqlCommand cmds = new SqlCommand();
            cmds.Connection = cn;
            cmds.CommandText = "splista_reque";
            cmds.CommandType = CommandType.StoredProcedure;

            SqlParameter tipo = new SqlParameter();
            tipo.ParameterName = "@tipo";
            tipo.SqlDbType = SqlDbType.VarChar;
            tipo.Size = 20;
            tipo.Value = er.Tipo; 
            cmds.Parameters.Add(tipo);

            SqlParameter estado = new SqlParameter();
            estado.ParameterName = "@estado";
            estado.SqlDbType = SqlDbType.VarChar;
            estado.Size = 10;
            estado.Value = er.Estado;
            cmds.Parameters.Add(estado);

            SqlParameter prioridad = new SqlParameter();
            prioridad.ParameterName = "@prioridad";
            prioridad.SqlDbType = SqlDbType.VarChar;
            prioridad.Size = 10;
            prioridad.Value = er.Prioridad;
            cmds.Parameters.Add(prioridad);

            cmds.ExecuteNonQuery();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmds);
            sqlDataAdapter.Fill(list);
            cn.Close();
            return list; 

                
        }

        public DataTable CambioEstado(ERequerimiento e)
        {
            DataTable estadoc = new DataTable(); 
            SqlCommand cmds = new SqlCommand();
            cmds.Connection = cn;
            cmds.CommandText = "spcambiar_estado";
            cmds.CommandType = CommandType.StoredProcedure;

            SqlParameter id_reque = new SqlParameter();
            id_reque.ParameterName = "@id_requerimiento";
            id_reque.SqlDbType = SqlDbType.Int;
            id_reque.Value = e.Id_requerimiento;
            cmds.Parameters.Add(id_reque);

            SqlParameter estado = new SqlParameter();
            estado.ParameterName = "@estado";
            estado.SqlDbType = SqlDbType.VarChar;
            estado.Size = 10;
            estado.Value = e.Estado;
            cmds.Parameters.Add(estado);

            SqlDataAdapter adapter = new SqlDataAdapter(cmds); 
            adapter.Fill(estadoc);
             
            return estadoc; 
           

        }
        public DataTable eliminarRequ(ERequerimiento erq)
        {
            DataTable eliminar = new DataTable();
            SqlCommand cmds = new SqlCommand();
            cmds.Connection = cn;
            cmds.CommandText = "speliminar_requerimiento";
            cmds.CommandType = CommandType.StoredProcedure;

            SqlParameter id_reque = new SqlParameter();
            id_reque.ParameterName = "@id_requerimiento";
            id_reque.SqlDbType = SqlDbType.Int;
            id_reque.Value = erq.Id_requerimiento;
            cmds.Parameters.Add(id_reque);

            SqlDataAdapter adapt = new SqlDataAdapter(cmds);
            adapt.Fill(eliminar);
            return eliminar; 
        }
    }
}
