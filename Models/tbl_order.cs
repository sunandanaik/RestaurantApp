//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_order()
        {
            this.tbl_orderdetail = new HashSet<tbl_orderdetail>();
        }
    
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> PaymentTypeId { get; set; }
        public Nullable<decimal> FinalTotal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_orderdetail> tbl_orderdetail { get; set; }
    }
}
