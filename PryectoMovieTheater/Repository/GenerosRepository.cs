using PryectoMovieTheater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PryectoMovieTheater.Repository
{
    public class GenerosRepository
    {
        MovieTheaterEntities bd = new MovieTheaterEntities();
        public List<Generos> ListOfGeneros()
        {
            var listadogeneros = bd.Generos.ToList();
            return listadogeneros;


        }
    }
}