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
    
    public partial class Records
    {
        public int ID { get; set; }
        public System.DateTime Date_Time { get; set; }
        public int Client { get; set; }
        public int Master { get; set; }
        public Nullable<int> Service { get; set; }
        public string Comment { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Masters Masters { get; set; }
        public virtual Service Service1 { get; set; }
    }
}
