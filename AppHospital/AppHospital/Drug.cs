//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppHospital
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drug
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drug()
        {
            this.DrugDetails = new HashSet<DrugDetail>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string UnitPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> Expiry { get; set; }
        public Nullable<System.DateTime> Manufacturer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrugDetail> DrugDetails { get; set; }
    }
}