﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OlympicGames.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OlympicsEntities : DbContext
    {
        public OlympicsEntities()
            : base("name=OlympicsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<athlete> athletes { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<game> games { get; set; }
        public virtual DbSet<medal> medals { get; set; }
        public virtual DbSet<result> results { get; set; }
        public virtual DbSet<results1> results1 { get; set; }
        public virtual DbSet<sport> sports { get; set; }
    }
}