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
    
    public partial class TD_Laymau
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TD_Laymau()
        {
            this.TD_Thongso = new HashSet<TD_Thongso>();
        }
    
        public string Laymau_ID { get; set; }
        public string TenLenh { get; set; }
        public System.DateTime Ngaytao { get; set; }
        public bool Trangthai { get; set; }
        public string Tramquantrac_ID { get; set; }
        public int Sochai { get; set; }
        public string Noidunglenh { get; set; }
        public string DataLoggerID { get; set; }
        public string Nguoitao { get; set; }
        public int STT { get; set; }
    
        public virtual TD_Tramquantrac TD_Tramquantrac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TD_Thongso> TD_Thongso { get; set; }
    }
}
