using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTheater.Models
{
    public class UpDatacopy
    {
        public int IdIngreso { get; set; }
        public string Titulo { get; set; }
        public HttpPostedFileBase Caratula { get; set; }
        public HttpPostedFileBase Ubicacion { get; set; }
     
        public string Genero { get; set; }
      
        public Nullable<System.DateTime> Año { get; set; }
        public string Sinopsis { get; set; }
    }
}