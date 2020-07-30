using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MvcReporte6.Utilerias;


namespace MvcReporte6.Models
{
    public class MunicipioRepositorio:IMunicipio
    {
        public Municipio ObtenerMunicipio(int idMunicipio)
        {
            Municipio Municipio;
            DataTable dtMunicipios = new DataTable();
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@idmunicipio", idMunicipio));
            dtMunicipios = BaseHelper.ejecutarConsulta("sp_municipio_mostrarporid", CommandType.StoredProcedure, parametros);
            if (dtMunicipios.Rows.Count > 0)
            {
                Municipio = new Municipio();
                Municipio.IdMunicipio = int.Parse(dtMunicipios.Rows[0]["idMunicipio"].ToString());
                Municipio.Nombre = dtMunicipios.Rows[0]["DescripMuni"].ToString();
                return Municipio;
            }
            else
            {

                return null;
            }


        }


        public List<Municipio> ObtenerMunicipios()
        {
            List<Municipio> lstmunicipio = new List<Municipio>();
            DataTable data = new DataTable();
            data = BaseHelper.ejecutarConsulta("sp_municipio_mostrartodo", CommandType.StoredProcedure);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Municipio empmunicipio= new Municipio();
                empmunicipio.IdMunicipio = int.Parse(data.Rows[i]["idmunicipio"].ToString());
                empmunicipio.Nombre = data.Rows[i]["DescripMuni"].ToString();
                lstmunicipio.Add(empmunicipio);
                
            }
            return lstmunicipio;
        }
    }
}