﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EbyxMarket
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ebyxMarket1Entities : DbContext
    {
        public ebyxMarket1Entities()
            : base("name=ebyxMarket1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLCalisan> TBLCalisans { get; set; }
        public virtual DbSet<TBLKategori> TBLKategoris { get; set; }
        public virtual DbSet<TBLKullanici> TBLKullanicis { get; set; }
        public virtual DbSet<TBLUrun> TBLUruns { get; set; }
    }
}
