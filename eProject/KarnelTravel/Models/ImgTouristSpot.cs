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
    
    public partial class ImgTouristSpot
    {
        public int Img_TouristSpot_Id { get; set; }
        public string Img_TouristSpot { get; set; }
        public Nullable<byte> Img_TouristSpot_Sort { get; set; }
        public string TouristSpot_Id { get; set; }
    
        public virtual TouristSpot TouristSpot { get; set; }
    }
}