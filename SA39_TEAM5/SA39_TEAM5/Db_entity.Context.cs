﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA39_TEAM5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SA39_PROJECTEntities1 : DbContext
    {
        public SA39_PROJECTEntities1()
            : base("name=SA39_PROJECTEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bookingdetail> bookingdetails { get; set; }
        public virtual DbSet<facilitydetail> facilitydetails { get; set; }
        public virtual DbSet<maintainancedetail> maintainancedetails { get; set; }
        public virtual DbSet<memberdetail> memberdetails { get; set; }
        public virtual DbSet<ref_key> ref_key { get; set; }
        public virtual DbSet<userdetail> userdetails { get; set; }
    }
}
