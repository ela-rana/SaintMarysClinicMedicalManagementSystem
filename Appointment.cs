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
    
    public partial class Appointment
    {
        public int ApptID { get; set; }
        public System.DateTime ApptDate { get; set; }
        public System.TimeSpan ApptTime { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int PCMID { get; set; }
        public int PatientID { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Patient Patient1 { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
    }
}
