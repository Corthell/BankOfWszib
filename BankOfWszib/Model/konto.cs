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
    
    public partial class konto
    {
        public int kontoId { get; set; }
        public int uzytkownikId { get; set; }
        public Nullable<double> saldo { get; set; }
    
        public virtual uzytkownik uzytkownik { get; set; }
    }
}