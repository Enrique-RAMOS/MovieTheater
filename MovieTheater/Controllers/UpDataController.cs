using MovieTheater.Models;
using MovieTheater.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieTheater.Controllers
{

    public class UpDataController : Controller
    {
        UpDataRepository updataRepository = new UpDataRepository();
        UpData upData = new UpData();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UpDatacopy upData)
        {
            string _FileName = Path.GetFileName(upData.Caratula.FileName);

            string _path = Path.Combine(Server.MapPath("/recursos"), _FileName);

            string _FileNameubicacion = Path.GetFileName(upData.Ubicacion.FileName);

            string _pathubicacion = Path.Combine(Server.MapPath("/recursos"), _FileNameubicacion);

            UpData _upd = new UpData();

            _upd.Titulo = upData.Titulo;
            _upd.Caratula = _path ;
            _upd.Ubicacion = _pathubicacion;
            _upd.Genero = upData.Genero;
            _upd.Año = upData.Año;
            _upd.Sinopsis = upData.Sinopsis;

            //upData.Caratula = _path;

            //upData.Ubicacion = _pathubicacion;

            updataRepository.Create(_upd);

            String ruta = Server.MapPath("~/recursos/");
            ruta += upData.Ubicacion.FileName;
            ruta += upData.Caratula.FileName;
            upData.Ubicacion.SaveAs(ruta);
            upData.Caratula.SaveAs(ruta);


            return View("");

          

          
        }
        public ActionResult Home()
        {
            return View();
        }
    }
}