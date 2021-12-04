using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace MovieTheater.Servicios
{
    interface ILogin
    {
        void Create(Login l);

        void Delete(Login l);



        List<Login> ListDataLogin();
    }
}
