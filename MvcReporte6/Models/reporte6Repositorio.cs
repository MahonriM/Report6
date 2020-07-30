using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MvcReporte6.Utilerias;

namespace MvcReporte6.Models
{
    public class reporte6Repositorio:IReporte6
    {
        public List<Reporte6> obtenerReportes(int IdMunicipio)
        {       
            DataTable datos = new DataTable();
            List<Reporte6> lstrp6 = new List<Reporte6>();
            //DtsSql datset = new DtsSql();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idmunicipio", IdMunicipio));
            datos = BaseHelper.ejecutarConsulta("spreporte6", CommandType.StoredProcedure, parametros);
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                Reporte6 Report6 = new Reporte6();
                Report6.CantidadCamion = int.Parse(datos.Rows[i]["@camiones"].ToString());
                Report6.CantidadEmpleado = int.Parse(datos.Rows[i]["@chofer"].ToString());
                Report6.Matutino = int.Parse(datos.Rows[i]["@turnom"].ToString());
                Report6.Vespertino = int.Parse(datos.Rows[i]["@turnov"].ToString());
                Report6.Nocturno = int.Parse(datos.Rows[i]["@turnon"].ToString());
                lstrp6.Add(Report6);
            }

            
            return lstrp6;
            
        }


        public Reporte6 ObtenerReport6(int IdMunicipio)
        {
            Reporte6 Report6;
            DataTable datos = new DataTable();
            //List<Reporte6> lstrp6 = new List<Reporte6>();
            //DtsSql datset = new DtsSql();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idmunicipio", IdMunicipio));
            datos = BaseHelper.ejecutarConsulta("SPREPORTE6", CommandType.StoredProcedure, parametros);
            //for (int i = 0; i < datos.Rows.Count; i++)
            if (datos.Rows.Count>0)
            {
                Report6 = new Reporte6();
                Report6.CantidadCamion = int.Parse(datos.Rows[0]["camiones"].ToString());
                Report6.CantidadEmpleado = int.Parse(datos.Rows[0]["chofer"].ToString());
                Report6.Matutino = int.Parse(datos.Rows[0]["turnomatutino"].ToString());
                Report6.Vespertino = int.Parse(datos.Rows[0]["turnovespertino"].ToString());
                Report6.Nocturno = int.Parse(datos.Rows[0]["turnonocturno"].ToString());
                return (Report6);
   
            }
            
            else
	      {
              return null;
          }
 
        }
    }
}