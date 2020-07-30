using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcReporte6.Models;
using IBM.Data.DB2;

namespace MvcReporte6.Controllers
{
    public class Reporte6Controller : Controller
    {
        Reporte6 rep6 = new Reporte6();
        Municipio mun = new Municipio();
        MunicipioRepositorio municipiorep = new MunicipioRepositorio();
        reporte6Repositorio repor6 = new reporte6Repositorio();
        
        public ActionResult Index()
        {   
            List<Municipio> LstMunicipio;
            LstMunicipio = municipiorep.ObtenerMunicipios();
            
            ViewData["municipios"] = new SelectList(LstMunicipio, "IdMunicipio", "Nombre");
        
            return View();

        }
       [HttpPost]
      public ActionResult Index(Municipio mun,int IdMunicipio) {
         List<Municipio> LstMunicipio;
  
       LstMunicipio = municipiorep.ObtenerMunicipios();

         ViewData["municipios"] = new SelectList(LstMunicipio, "IdMunicipio", "Nombre");
         
           //Reporte6 litrep6 = (repor6.ObtenerReport6(IdMunicipio));
         
        //ViewData["nombreMunicipio"] = municipiorep.ObtenerMunicipios();
        //    var ta = new DataSet1TableAdapters.SPREPORTE6TableAdapter();
          //var dt = ta.GetData(IdMunicipio);
        //IdMunicipio=mun.IdMunicipio;
           
        Response.Redirect("/Reporte6/Detail?IdMunicipio=" + IdMunicipio);
         return RedirectToRoute("Ejemplo", IdMunicipio);
        }
       
        public ActionResult Detail(int IdMunicipio)
       {
          List<Municipio> LstMunicipio;
           LstMunicipio = municipiorep.ObtenerMunicipios();
           //ViewData["municipios"] = new SelectList(LstMunicipio, "idMunicipio", "nombre");
           //List<Municipio> LstMunicipio = new List<Municipio>();
           //lstMunicipio.Add(new Municipio2 { idMunicipio = -1, DescripMuni = "Todos" });
           //LstMunicipio.Add(new Municipio {IdMunicipio=10, });

           LstMunicipio = municipiorep.ObtenerMunicipios();

           ViewData["municipios"] = new SelectList(LstMunicipio, "IdMunicipio", "Nombre");
        
            Reporte6 litrep6=(repor6.ObtenerReport6(IdMunicipio));
           // Municipio mun;
                       //var lt6 = repor6.ObtenerReport6(IdMunicipio);
            //litrep6 = (repor6.ObtenerReport6(30));
            //var ta = new DataSet1TableAdapters.SPREPORTE6TableAdapter();
            //var dt = ta.GetData(IdMunicipio);
            //foreach (DataSet1.SPREPORTE6Row row in dt.Rows)
            //{   
              
            //}
            //ta.Dispose();
           // dt.Dispose();
            //List<Reporte6> listarep6 = new List<Reporte6>();
            //listarep6.Add(new Reporte6 { CantidadCamion = 1, CantidadEmpleado=2, Matutino=3,Vespertino= 4,Nocturno= 5 });
            //listarep6.Add(new Reporte6 { CantidadCamion = 2, CantidadEmpleado = 3, Matutino = 4, Vespertino = 5, Nocturno = 4 });
            return View(litrep6);
            
        }
        
    }
}

