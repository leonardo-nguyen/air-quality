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
    
    public partial class CMS_ContactUs
    {
        public int ContactUs_ID { get; set; }
        public string Topic_ID { get; set; }
        public string ContactUs_Name { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Nick { get; set; }
        public string Contents { get; set; }
        public Nullable<int> IsLang { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedBy { get; set; }
    
        public virtual CMS_Topic CMS_Topic { get; set; }
    }
}
