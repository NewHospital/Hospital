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
    
    public partial class PrescriptionDetail
    {
        public int PrescriptionId { get; set; }
        public int DrugId { get; set; }
        public decimal Qnty { get; set; }
        public bool IsReceived { get; set; }
    
        public virtual Drugs Drugs { get; set; }
        public virtual Prescription Prescription { get; set; }
    }
}
