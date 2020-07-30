using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcReporte6.Models;

namespace MvcReporte6.Models
{ 
    public class Reporte6
    {
        public int IdMunicipio { get; set; }
        public int CantidadCamion { get; set; }
        public int CantidadEmpleado { get; set; }
        public int Matutino { get; set; }
        public int Vespertino { get; set; }
        public int Nocturno { get; set; }
    }
}