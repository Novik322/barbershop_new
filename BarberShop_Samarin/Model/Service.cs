//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarberShop_Samarin.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public Service()
        {
            this.Records = new HashSet<Records>();
        }
    
        public int ID { get; set; }
        public string Name_Service { get; set; }
        public decimal Price_Service { get; set; }
    
        public virtual ICollection<Records> Records { get; set; }
    }
}
