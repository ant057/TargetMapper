﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TargetMapperData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RDM_AGENT_CODE> RDM_AGENT_CODE { get; set; }
        public virtual DbSet<RDM_AGENT_CODE_MAPPING> RDM_AGENT_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_ASL_CODE> RDM_ASL_CODE { get; set; }
        public virtual DbSet<RDM_ASL_CODE_MAPPING> RDM_ASL_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_BUS_UNIT_CODE> RDM_BUS_UNIT_CODE { get; set; }
        public virtual DbSet<RDM_BUS_UNIT_CODE_MAPPING> RDM_BUS_UNIT_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_CAT_CODE> RDM_CAT_CODE { get; set; }
        public virtual DbSet<RDM_CAT_CODE_MAPPING> RDM_CAT_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_CLASS_CODE> RDM_CLASS_CODE { get; set; }
        public virtual DbSet<RDM_CLASS_CODE_MAPPING> RDM_CLASS_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_COMPANY_CODE> RDM_COMPANY_CODE { get; set; }
        public virtual DbSet<RDM_COMPANY_CODE_MAPPING> RDM_COMPANY_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_COUNTY_UNIT_CODE> RDM_COUNTY_UNIT_CODE { get; set; }
        public virtual DbSet<RDM_COUNTY_UNIT_CODE_MAPPING> RDM_COUNTY_UNIT_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_COVERAGE_CODE> RDM_COVERAGE_CODE { get; set; }
        public virtual DbSet<RDM_COVERAGE_CODE_MAPPING> RDM_COVERAGE_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_GRPLINE_CODE> RDM_GRPLINE_CODE { get; set; }
        public virtual DbSet<RDM_GRPLINE_CODE_MAPPING> RDM_GRPLINE_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_MGMT_SEG_CODE> RDM_MGMT_SEG_CODE { get; set; }
        public virtual DbSet<RDM_MGMT_SEG_CODE_MAPPING> RDM_MGMT_SEG_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_PROGRAM_CODE> RDM_PROGRAM_CODE { get; set; }
        public virtual DbSet<RDM_PROGRAM_CODE_MAPPING> RDM_PROGRAM_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_STATE_CODE> RDM_STATE_CODE { get; set; }
        public virtual DbSet<RDM_STATE_CODE_MAPPING> RDM_STATE_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_SUB_LINE_CODE> RDM_SUB_LINE_CODE { get; set; }
        public virtual DbSet<RDM_SUB_LINE_CODE_MAPPING> RDM_SUB_LINE_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_TERR_UNDR_CODE> RDM_TERR_UNDR_CODE { get; set; }
        public virtual DbSet<RDM_TERR_UNDR_CODE_MAPPING> RDM_TERR_UNDR_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_UNDERWRITER_CODE> RDM_UNDERWRITER_CODE { get; set; }
        public virtual DbSet<RDM_UNDERWRITER_CODE_MAPPING> RDM_UNDERWRITER_CODE_MAPPING { get; set; }
        public virtual DbSet<RDM_USERLINE_CODE> RDM_USERLINE_CODE { get; set; }
        public virtual DbSet<RDM_USERLINE_CODE_MAPPING> RDM_USERLINE_CODE_MAPPING { get; set; }
    }
}
