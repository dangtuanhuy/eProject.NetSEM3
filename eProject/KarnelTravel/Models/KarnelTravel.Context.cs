﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KarnelTravelEntities : DbContext
    {
        public KarnelTravelEntities()
            : base("name=KarnelTravelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<ImgFood> ImgFoods { get; set; }
        public virtual DbSet<ImgHotel> ImgHotels { get; set; }
        public virtual DbSet<ImgRestaurant> ImgRestaurants { get; set; }
        public virtual DbSet<ImgRoom> ImgRooms { get; set; }
        public virtual DbSet<ImgTouristSpot> ImgTouristSpots { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TouristSpot> TouristSpots { get; set; }
        public virtual DbSet<Transportation> Transportations { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripDetail> TripDetails { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
    }
}