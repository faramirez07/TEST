﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.ModelData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataEntities : DbContext
    {
        public DataEntities()
            : base("name=DataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientM> ClientMs { get; set; }
        public virtual DbSet<PolicyClientM> PolicyClientMs { get; set; }
        public virtual DbSet<PolicyM> PolicyMs { get; set; }
        public virtual DbSet<TypePolicyM> TypePolicyMs { get; set; }
        public virtual DbSet<TypeRiskM> TypeRiskMs { get; set; }
    }
}