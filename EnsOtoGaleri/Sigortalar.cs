//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnsOtoGaleri
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sigortalar
    {
        public int SigortaID { get; set; }
        public int SatisID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public Nullable<System.DateTime> BaslangicT { get; set; }
        public Nullable<System.DateTime> BitisT { get; set; }
        public Nullable<int> Ucret { get; set; }
        public int SubeID { get; set; }
    
        public virtual Satislar Satislar { get; set; }
        public virtual SubeAbonelik SubeAbonelik { get; set; }
    }
}
