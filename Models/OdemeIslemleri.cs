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
    
    public partial class OdemeIslemleri
    {
        public int OdemeIslemiId { get; set; }
        public Nullable<int> SahaId { get; set; }
        public Nullable<int> RezId { get; set; }
        public Nullable<int> KullaniciId { get; set; }
    
        public virtual Kullanicilar Kullanicilar { get; set; }
        public virtual Rezervasyon Rezervasyon { get; set; }
        public virtual Sahalar Sahalar { get; set; }
    }
}