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
    
    public partial class CMS_Question
    {
        public int Question_ID { get; set; }
        public string Question_Name { get; set; }
        public string Topic_ID { get; set; }
        public string Contents { get; set; }
        public string Department_Name { get; set; }
        public string SenderName { get; set; }
        public bool SenderSex { get; set; }
        public string SenderAddress { get; set; }
        public string SenderTelephone { get; set; }
        public string SenderMobile { get; set; }
        public string SenderEmail { get; set; }
        public string SenderNickName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ReplyContents { get; set; }
        public string ReplyName { get; set; }
        public Nullable<System.DateTime> ReplyCreatedDate { get; set; }
        public Nullable<int> IsLang { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> IsOrder { get; set; }
    
        public virtual CMS_Topic CMS_Topic { get; set; }
    }
}
