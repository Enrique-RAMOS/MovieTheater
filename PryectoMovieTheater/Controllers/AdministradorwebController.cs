using PryectoMovieTheater.Models;
using PryectoMovieTheater.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PryectoMovieTheater.Controllers
{
    public class AdministradorwebController : Controller
    {

      

        GenerosRepository generosRepository = new GenerosRepository();
        Generos students = new Generos();
        // GET: Administradorweb
        public ActionResult UpData()
        {

            var informationGeneros = generosRepository.ListOfGeneros();
           

            List<SelectListItem> ComboboxOfGeneros = new List<SelectListItem>();
            
            foreach (var iteracion in informationGeneros)
            {
                ComboboxOfGeneros.Add(new SelectListItem
                {

                    Text = iteracion.Generos1,
                    Value = Convert.ToString(iteracion.Generos1)
                });
                ViewBag.listOfGeneroscombobox = ComboboxOfGeneros;
            }
          
      
            return View();
        }





        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Recursos imagen)
        {



            String ruta = Server.MapPath("~/img/");
            ruta += imagen.file.FileName;

            imagen.file.SaveAs(ruta);

            return View();
        }
        public ActionResult Inicio()
        {
            return View();
        }
    }
}