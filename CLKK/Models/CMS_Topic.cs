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
    
    public partial class CMS_Topic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CMS_Topic()
        {
            this.CMS_Album = new HashSet<CMS_Album>();
            this.CMS_ContactUs = new HashSet<CMS_ContactUs>();
            this.CMS_Document = new HashSet<CMS_Document>();
            this.CMS_MediaGroup = new HashSet<CMS_MediaGroup>();
            this.CMS_News = new HashSet<CMS_News>();
            this.CMS_Notice = new HashSet<CMS_Notice>();
            this.CMS_Question = new HashSet<CMS_Question>();
            this.CMS_SlideShow = new HashSet<CMS_SlideShow>();
            this.CMS_Social = new HashSet<CMS_Social>();
            this.CMS_Topic1 = new HashSet<CMS_Topic>();
        }
    
        public string Topic_ID { get; set; }
        public string Topic_Name { get; set; }
        public string Parent_ID { get; set; }
        public bool IsMenu { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> IsOrder { get; set; }
        public System.DateTime CreatedBy { get; set; }
        public string Users_ID { get; set; }
        public string Contents { get; set; }
        public Nullable<int> Topic_Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_Album> CMS_Album { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_ContactUs> CMS_ContactUs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_Document> CMS_Document { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_MediaGroup> CMS_MediaGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_News> CMS_News { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_Notice> CMS_Notice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_Question> CMS_Question { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_SlideShow> CMS_SlideShow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_Social> CMS_Social { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMS_Topic> CMS_Topic1 { get; set; }
        public virtual CMS_Topic CMS_Topic2 { get; set; }
    }
}
