﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RubiconERPv1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RubiconDBEntities : DbContext
    {
        public RubiconDBEntities()
            : base("name=RubiconDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BSMGR0BOM001> BSMGR0BOM001 { get; set; }
        public virtual DbSet<BSMGR0BOMCONTENT> BSMGR0BOMCONTENT { get; set; }
        public virtual DbSet<BSMGR0BOMHEAD> BSMGR0BOMHEAD { get; set; }
        public virtual DbSet<BSMGR0CCM001> BSMGR0CCM001 { get; set; }
        public virtual DbSet<BSMGR0CCMHEAD> BSMGR0CCMHEAD { get; set; }
        public virtual DbSet<BSMGR0CCMTEXT> BSMGR0CCMTEXT { get; set; }
        public virtual DbSet<BSMGR0GEN001> BSMGR0GEN001 { get; set; }
        public virtual DbSet<BSMGR0GEN002> BSMGR0GEN002 { get; set; }
        public virtual DbSet<BSMGR0GEN003> BSMGR0GEN003 { get; set; }
        public virtual DbSet<BSMGR0GEN004> BSMGR0GEN004 { get; set; }
        public virtual DbSet<BSMGR0GEN005> BSMGR0GEN005 { get; set; }
        public virtual DbSet<BSMGR0MAT001> BSMGR0MAT001 { get; set; }
        public virtual DbSet<BSMGR0MATHEAD> BSMGR0MATHEAD { get; set; }
        public virtual DbSet<BSMGR0MATTEXT> BSMGR0MATTEXT { get; set; }
        public virtual DbSet<BSMGR0ROT001> BSMGR0ROT001 { get; set; }
        public virtual DbSet<BSMGR0ROT002> BSMGR0ROT002 { get; set; }
        public virtual DbSet<BSMGR0ROT003> BSMGR0ROT003 { get; set; }
        public virtual DbSet<BSMGR0ROTBOMCONTENT> BSMGR0ROTBOMCONTENT { get; set; }
        public virtual DbSet<BSMGR0ROTHEAD> BSMGR0ROTHEAD { get; set; }
        public virtual DbSet<BSMGR0ROTOPRCONTENT> BSMGR0ROTOPRCONTENT { get; set; }
        public virtual DbSet<BSMGR0WCM001> BSMGR0WCM001 { get; set; }
        public virtual DbSet<BSMGR0WCMHEAD> BSMGR0WCMHEAD { get; set; }
        public virtual DbSet<BSMGR0WCMOPR> BSMGR0WCMOPR { get; set; }
        public virtual DbSet<BSMGR0WCMTEXT> BSMGR0WCMTEXT { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
