using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcReporte6.Models
{
    public interface IMunicipio
    {   List<Municipio>ObtenerMunicipios();
        Municipio ObtenerMunicipio(int idMunicipio);
    }
}