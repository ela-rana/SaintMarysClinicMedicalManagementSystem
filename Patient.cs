//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaintMarysClinicMedicalManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public int UserID { get; set; }
        public System.DateTime DOB { get; set; }
        public string Address { get; set; }
        public int PCMUserID { get; set; }
    
        public virtual MMSUser MMSUser { get; set; }
        public virtual MMSUser MMSUser1 { get; set; }
    }
}
