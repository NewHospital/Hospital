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
    
    public partial class SupplierAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplierAddress()
        {
            this.SupplierContacts = new HashSet<SupplierContact>();
        }
    
        public int AddressId { get; set; }
        public int SupplierId { get; set; }
        public string SupplierAdress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierContact> SupplierContacts { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
