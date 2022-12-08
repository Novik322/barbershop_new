using BarberShop_Samarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop_Samarin.AppData
{
     class RecordsBuilder
    {
        List<Model.Records> records = AppConnect.project_model.Records.ToList();
        public RecordsBuilder()
        {
        }
        public List<Model.Records> GetRecords()
        {
            return records;
        }
    }
}
