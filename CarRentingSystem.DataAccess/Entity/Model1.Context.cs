﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentingSystem.DataAccess.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarRentingSystemEntities : DbContext
    {
        public CarRentingSystemEntities()
            : base("name=CarRentingSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<RentInfos> RentInfos { get; set; }
        public virtual DbSet<Staffs> Staffs { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Vehicles> Vehicles { get; set; }
    }
}
