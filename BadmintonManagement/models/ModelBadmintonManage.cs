using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BadmintonManagement.Models
{
    public partial class ModelBadmintonManage : DbContext
    {
        public ModelBadmintonManage()
            : base("name=ModelBadmintonManage")
        {
        }

        public virtual DbSet<C_SERVICE> C_SERVICE { get; set; }
        public virtual DbSet<C_User> C_User { get; set; }
        public virtual DbSet<BRANCH> BRANCHes { get; set; }
        public virtual DbSet<COURT> COURTs { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<PRICE> PRICEs { get; set; }
        public virtual DbSet<RECEIPT> RECEIPTs { get; set; }
        public virtual DbSet<RESERVATION> RESERVATIONs { get; set; }
        public virtual DbSet<RF_DETAIL> RF_DETAIL { get; set; }
        public virtual DbSet<SERVICE_DETAIL> SERVICE_DETAIL { get; set; }
        public virtual DbSet<SERVICE_RECEIPT> SERVICE_RECEIPT { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_SERVICE>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_SERVICE>()
                .HasMany(e => e.SERVICE_DETAIL)
                .WithRequired(e => e.C_SERVICE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<C_User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<C_User>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<C_User>()
             .Property(e => e.Status)
             .IsUnicode(false);

            modelBuilder.Entity<BRANCH>()
                .HasMany(e => e.COURTs)
                .WithRequired(e => e.BRANCH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COURT>()
                .HasMany(e => e.RF_DETAIL)
                .WithRequired(e => e.COURT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PRICE>()
                .Property(e => e.PriceID)
                .IsUnicode(false);

            modelBuilder.Entity<PRICE>()
                .Property(e => e.PriceTag)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.Total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RESERVATION>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<RESERVATION>()
                .Property(e => e.Deposite)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RESERVATION>()
                .HasMany(e => e.RF_DETAIL)
                .WithRequired(e => e.RESERVATION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RF_DETAIL>()
                .Property(e => e.PriceID)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICE_RECEIPT>()
                .Property(e => e.Total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SERVICE_RECEIPT>()
                .HasMany(e => e.SERVICE_DETAIL)
                .WithRequired(e => e.SERVICE_RECEIPT)
                .WillCascadeOnDelete(false);
        }
    }
}