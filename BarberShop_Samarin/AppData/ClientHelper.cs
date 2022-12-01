using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop_Samarin.AppData
{
    class ClientHelper : AppConnect
    {
        public List<Model.Clients> GetMaterials()
        {
            return project_model.Clients.ToList();
        }

        public List<Model.Clients> GetMaterials(string search)
        {
            return project_model.Clients.ToList().Where(i => i.Name.Contains(search)).ToList();
        }
    }
}
