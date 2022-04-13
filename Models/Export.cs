//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apple_Clone_Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Export
    {
        public string ExportID { get; set; }
        public Nullable<System.DateTime> ExportedDate { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string UserID { get; set; }
        public string StoreID { get; set; }
    
        public virtual ExportDetail ExportDetail { get; set; }
        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
    }
}