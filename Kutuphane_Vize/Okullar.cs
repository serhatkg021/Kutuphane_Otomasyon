//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutuphane_Vize
{
    using System;
    using System.Collections.Generic;
    
    public partial class Okullar
    {
        public Okullar()
        {
            this.Uyeler = new HashSet<Uyeler>();
        }
    
        public int No { get; set; }
        public string okulAd { get; set; }
    
        public virtual ICollection<Uyeler> Uyeler { get; set; }
    }
}
