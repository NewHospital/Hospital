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
    
    public partial class BuyingInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuyingInvoice()
        {
            this.BuyingInvoiceDetails = new HashSet<BuyingInvoiceDetail>();
        }
    
        public int InvoiceId { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public int SupplierId { get; set; }
        public string InvoiceNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyingInvoiceDetail> BuyingInvoiceDetails { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
