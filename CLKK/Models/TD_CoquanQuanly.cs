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
    
    public partial class TD_CoquanQuanly
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TD_CoquanQuanly()
        {
            this.TD_Tramquantrac = new HashSet<TD_Tramquantrac>();
        }
    
        public string CoquanQuanly_ID { get; set; }
        public string CoquanQuanly_Ten { get; set; }
        public Nullable<int> STT { get; set; }
        public bool Trangthai { get; set; }
        public string MaCoquan { get; set; }
        public string DaumoiLienhe { get; set; }
        public string SDT { get; set; }
        public string Diadanh_ID { get; set; }
        public string Mota { get; set; }
        public Nullable<double> Kinhdo { get; set; }
        public Nullable<double> Vido { get; set; }
        public string CapCha_ID { get; set; }
        public int Level { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TD_Tramquantrac> TD_Tramquantrac { get; set; }
    }
}
