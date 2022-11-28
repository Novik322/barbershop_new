﻿using BarberShop_Samarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop_Samarin.AppData
{
    class AppConnect
    {
        public static SamarinR_BarbershopEntities project_model;

        public static SamarinR_BarbershopEntities GetContext()
        {
            if (project_model == null)
            {
                project_model = new SamarinR_BarbershopEntities();
            }
            return project_model;
        }
    }
}