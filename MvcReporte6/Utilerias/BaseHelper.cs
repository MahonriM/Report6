using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MvcReporte6.Utilerias
{
    public class BaseHelper
    {
        public static int ejecutarSentencia(string sentencia, CommandType tipo, List<SqlParameter> parametros = null)
        {
            int filasAfectadas = -1;
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                con.Open();
                comando.Connection = con;
                comando.CommandType = tipo;
                comando.CommandText = sentencia;
                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros.ToArray());
                }
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return filasAfectadas;
        }
        public static DataTable ejecutarConsulta(string sentencia, CommandType tipo, List<SqlParameter> parametros = null)
        {

            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable datos = new DataTable();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                con.Open();
                comando.Connection = con;
                comando.CommandType = tipo;
                comando.CommandText = sentencia;
                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros.ToArray());
                }
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return datos;
        }

    }
}