//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalMobil
{
    using System;
    using System.Collections.Generic;
    
    public partial class orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orders()
        {
            this.order_car = new HashSet<order_car>();
            this.payments = new HashSet<payments>();
        }
    
        public int id_order { get; set; }
        public Nullable<int> id_member { get; set; }
        public string invoice_number { get; set; }
        public Nullable<decimal> total_price { get; set; }
        public Nullable<System.DateTime> tgl_order { get; set; }
        public Nullable<int> id_admin { get; set; }
        public string status { get; set; }
    
        public virtual admins admins { get; set; }
        public virtual members members { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_car> order_car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<payments> payments { get; set; }
    }
}