//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLKK.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CMS_Notice
    {
        public int Notice_ID { get; set; }
        public string Notice_Name { get; set; }
        public string Topic_ID { get; set; }
        public bool IsHot { get; set; }
        public string Images { get; set; }
        public string Contents { get; set; }
        public string Details { get; set; }
        public string Keywords { get; set; }
        public string IsWriter { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> IsVisitor { get; set; }
        public Nullable<int> IsLang { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> IsOrder { get; set; }
        public System.DateTime CreatedBy { get; set; }
        public string UserName { get; set; }
    
        public virtual CMS_Topic CMS_Topic { get; set; }
    }
}
