//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fellow
    {
        public int FellowID { get; set; }
        public string FellowName { get; set; }
        public int SoSecNo { get; set; }
        public string PhoneNumber { get; set; }
        public int PatientId { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
