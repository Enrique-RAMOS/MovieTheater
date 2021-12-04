using MovieTheater.Models;
using MovieTheater.Servicios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MovieTheater.Repository
{
    public class UpDataRepository : IUpData
    {
        MovieTheaterEntities bd = new MovieTheaterEntities();


        public void Create(UpData c)
        {

            bd.UpData.Add(c);
            bd.SaveChanges();
        }



        public void Delete(UpData c)

        {
            c = bd.UpData.Find(c.IdIngreso);

            bd.UpData.Remove(c);
            bd.SaveChanges();
        }




        public List<UpData> ListDataUpData()
        {
            var ListOfDataofUpData = bd.UpData.ToList();
            return ListOfDataofUpData;
        }

    }

}