﻿using PryectoMovieTheater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryectoMovieTheater.Servicios
{
    interface IUpData
    {
        void Create(UpData c);

        void Delete(UpData c);



        List<UpData> ListUpData();
    }
}
