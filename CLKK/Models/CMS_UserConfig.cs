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
    
    public partial class CMS_UserConfig
    {
        public int UserConfig_ID { get; set; }
        public string UserGroup_ID { get; set; }
        public string Module_ID { get; set; }
        public bool IsCreate { get; set; }
        public bool IsRead { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsDelete { get; set; }
    
        public virtual CMS_Config CMS_Config { get; set; }
        public virtual CMS_UserGroup CMS_UserGroup { get; set; }
    }
}
