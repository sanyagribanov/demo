//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace turagentstvo.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID { get; set; }
        public string login { get; set; }
        public Nullable<int> RoleID { get; set; }
        public string Password { get; set; }
    
        public virtual Role Role { get; set; }

        public string avatar { get; set; }
    }
}
