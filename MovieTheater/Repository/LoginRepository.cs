using MovieTheater.Models;
using MovieTheater.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MovieTheater.Repository
{
    public class LoginRepository 
    {
        MovieTheaterEntities bd = new MovieTheaterEntities();


        public void Create(Login l)
        {

            bd.Login.Add(l);
            bd.SaveChanges();
        }

        public void Delete(Login l)

        {
            l = bd.Login.Find(l.IdUser);

            bd.Login.Remove(l);
            bd.SaveChanges();
        }




        public List<Login> ListDataLogin()
        {
            var ListOfDataofLogin = bd.Login.ToList();
            return ListOfDataofLogin;
        }
    }
}