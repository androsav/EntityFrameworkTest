//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Email
    {
        public System.Guid Email_Id { get; set; }
        public string Email_Name { get; set; }
        public Nullable<System.Guid> Employee_Id { get; set; }
        public Nullable<System.Guid> EmailType_Id { get; set; }
    
        public virtual EmailType EmailType { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
