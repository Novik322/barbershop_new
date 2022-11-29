using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop_Samarin.AppData
{
     class ClientsClass
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Master { get; set; }

        public Clients(string name, string phone, string master)
        {
            Name = name;
            Phone = phone;
            Master = master;

        }
    }
}
