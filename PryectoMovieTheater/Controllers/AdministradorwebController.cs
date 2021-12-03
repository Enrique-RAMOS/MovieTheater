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

        MovieTheaterEntities bd = new MovieTheaterEntities();

        GenerosRepository generosRepository = new GenerosRepository();
        Generos students = new Generos();
    


 

        [HttpGet]
        public ActionResult UpData(UpData datos)
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
          
      
            return View("UpData");
        }





        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UpData imagen)
        {



            String ruta = Server.MapPath("~/recursos/");
            ruta += imagen.file.FileName;

            imagen.file.SaveAs(ruta);

            return View("UpData");
        }
        public ActionResult Inicio()
        {
            return View();
        }
    }
}