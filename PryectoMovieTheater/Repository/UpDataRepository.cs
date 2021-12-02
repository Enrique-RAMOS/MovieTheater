using PryectoMovieTheater.Models;
using PryectoMovieTheater.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PryectoMovieTheater.Repository
{
   // MovieTheaterEntities
    public class UpDataRepository : IUpData
    {
        MovieTheaterEntities bd = new MovieTheaterEntities();

        public void Create(UpData c)
        {
            bd.UpData.Add(c);
            bd.SaveChanges();
        }

        public void Update(UpData c)

        {
            UpData datosactualizados = new UpData();
            datosactualizados = bd.UpData.Find(c.IdIngreso);

            datosactualizados.Titulo = c.Titulo;
            datosactualizados.Caratula = c.Caratula;
            datosactualizados.Ubicacion = c.Ubicacion;
            datosactualizados.Genero = c.Genero;
            datosactualizados.Año = c.Año;
            datosactualizados.Sinopsis = c.Sinopsis;


            bd.SaveChanges();
        }

        public void Delete(UpData c)

        {
            c = bd.UpData.Find(c.IdIngreso);
            _ = c;
            bd.UpData.Remove(c);
            bd.SaveChanges();
        }


        public List<UpData> ListDataCourses()
        {
            var ListOfUpData = bd.UpData.ToList();
            return ListOfUpData;
        }

        public List<UpData> ListUpData()
        {
            throw new NotImplementedException();
        }
    }
}