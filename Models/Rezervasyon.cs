//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaliSahaWPF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezervasyon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rezervasyon()
        {
            this.OdemeIslemleris = new HashSet<OdemeIslemleri>();
        }
    
        public int RezID { get; set; }
        public string RezNotu { get; set; }
        public Nullable<int> RezDate { get; set; }
        public Nullable<int> SahaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OdemeIslemleri> OdemeIslemleris { get; set; }
        public virtual Sahalar Sahalar { get; set; }
    }
}
