//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HFW
{
    using System;
    using System.Collections.Generic;
    
    public partial class Home_Front_workers_position
    {
        public int ID { get; set; }
        public Nullable<int> ID_Home_Front_Workers { get; set; }
        public Nullable<int> Id_Post { get; set; }
        public string Experience { get; set; }
    
        public virtual Home_Front_workers Home_Front_workers { get; set; }
        public virtual Post Post { get; set; }
    }
}
