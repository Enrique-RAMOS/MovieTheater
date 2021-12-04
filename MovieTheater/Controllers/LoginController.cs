using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieTheater.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult peliculas()
        {
            return View();
        }
        public ActionResult Series()
        {
            return View();
        }
        public ActionResult Animes()
        {
            return View();
        }
        public ActionResult VerVideo()
        {
            return View();
        }
    }
}