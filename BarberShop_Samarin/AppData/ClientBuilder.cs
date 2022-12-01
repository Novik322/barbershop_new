using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop_Samarin.AppData
{
    class ClientBuilder
    {
        List<Model.Clients> clients = AppConnect.project_model.Clients.ToList();
        public ClientBuilder()
        {

        }
        public List<Model.Clients> GetMaterials()
        {
            return clients;
        }
    }
}
