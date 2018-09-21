//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KarnelTravel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trip()
        {
            this.TripDetails = new HashSet<TripDetail>();
        }
    
        public string Trip_Id { get; set; }
        public string Trip_Name { get; set; }
        public string Trip_Details { get; set; }
        public Nullable<System.DateTime> Trip_Date { get; set; }
        public string Trip_Address { get; set; }
        public Nullable<bool> Trip_Status { get; set; }
        public string Customer_Id { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TripDetail> TripDetails { get; set; }
    }
}