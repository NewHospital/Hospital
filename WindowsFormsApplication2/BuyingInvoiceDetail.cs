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
    
    public partial class BuyingInvoiceDetail
    {
        public int InvoiceId { get; set; }
        public int DrugId { get; set; }
        public int Qnty { get; set; }
        public decimal pricePerUnit { get; set; }
        public System.DateTime ExpDate { get; set; }
    
        public virtual BuyingInvoice BuyingInvoice { get; set; }
        public virtual Drug Drug { get; set; }
    }
}
