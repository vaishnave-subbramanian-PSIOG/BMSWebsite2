﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMSDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BMSApplicationEntities : DbContext
    {
        public BMSApplicationEntities()
            : base("name=BMSApplicationEntities")
        {
            this.Configuration.ProxyCreationEnabled = false;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BOOKING> BOOKINGs { get; set; }
        public virtual DbSet<CASTING> CASTINGs { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<DIRECTOR> DIRECTORs { get; set; }
        public virtual DbSet<GENRE> GENREs { get; set; }
        public virtual DbSet<MOVIE> MOVIEs { get; set; }
        public virtual DbSet<MOVIEHALL> MOVIEHALLs { get; set; }
        public virtual DbSet<MOVIEHALLSEAT> MOVIEHALLSEATs { get; set; }
        public virtual DbSet<PAYMENTDETAIL> PAYMENTDETAILS { get; set; }
        public virtual DbSet<SHOW> SHOWs { get; set; }
        public virtual DbSet<SHOWINFO> SHOWINFOes { get; set; }
        public virtual DbSet<THEATRECOMPLEX> THEATRECOMPLEXes { get; set; }
        public virtual DbSet<TICKETRESERVATION> TICKETRESERVATIONs { get; set; }
    }
}
