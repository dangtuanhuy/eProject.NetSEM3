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
    
    public partial class Hotel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hotel()
        {
            this.ImgHotels = new HashSet<ImgHotel>();
            this.Rooms = new HashSet<Room>();
        }
    
        public string Hotel_Id { get; set; }
        public string Hotel_Name { get; set; }
        public string Hotel_Address { get; set; }
        public string Hotel_Details { get; set; }
        public string TouristSpot_Id { get; set; }
    
        public virtual TouristSpot TouristSpot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImgHotel> ImgHotels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
