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
    
    public partial class CMS_Gallery
    {
        public int Gallery_ID { get; set; }
        public Nullable<int> Album_ID { get; set; }
        public string Contents { get; set; }
        public string FileSource { get; set; }
        public Nullable<int> IsOrder { get; set; }
        public bool IsHot { get; set; }
    
        public virtual CMS_Album CMS_Album { get; set; }
    }
}
