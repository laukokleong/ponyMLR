﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PonyMLR.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ponytestEntities : DbContext
    {
        public ponytestEntities()
            : base("name=ponytestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<jockey_info> jockey_info { get; set; }
        public DbSet<race_info> race_info { get; set; }
        public DbSet<race_result> race_result { get; set; }
        public DbSet<racetrack> racetracks { get; set; }
        public DbSet<trainer_info> trainer_info { get; set; }
    }
}
