//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankOfWszib.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class transakcja
    {
        public int transakcjaId { get; set; }
        public int uzytkownikId { get; set; }
        public string nrOdbiorcy { get; set; }
        public System.DateTime dataPrzelewu { get; set; }
        public string miasto { get; set; }
        public string ulica { get; set; }
        public string nrLokalu { get; set; }
        public Nullable<double> kwotaPrzelewu { get; set; }
        public string tytulPrzelewu { get; set; }
    
        public virtual uzytkownik uzytkownik { get; set; }
    }
}