//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payments
    {
        public int PaymentId { get; set; }
        public System.DateTime paymentDate { get; set; }
        public int ReservationId { get; set; }
        public string ReceiptSerial { get; set; }
        public decimal Amount { get; set; }
        public string Discription { get; set; }
    
        public virtual Reservations Reservations { get; set; }
    }
}
