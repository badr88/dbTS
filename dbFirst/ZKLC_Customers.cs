//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZKLC_Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZKLC_Customers()
        {
            this.ZKLC_CustomerCards = new HashSet<ZKLC_CustomerCards>();
            this.ZKLC_Transfers = new HashSet<ZKLC_Transfers>();
        }
    
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Middle_Name { get; set; }
        public string TaxID { get; set; }
        public Nullable<int> Sts { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZKLC_CustomerCards> ZKLC_CustomerCards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZKLC_Transfers> ZKLC_Transfers { get; set; }
    }
}
