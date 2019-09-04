using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRSDataTablesProject.Models {
    public class PRSdb : DbContext {

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>(pn => {
                pn.Property(p => p.Price).HasColumnType("decimal(11, 2)");
                });

                modelBuilder.Entity<Product>()
                .HasIndex(p => p.PartNbr)
                .IsUnique();

                modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

                modelBuilder.Entity<Vendor>()
                  .HasIndex(v => v.Code)
                  .IsUnique();

                modelBuilder.Entity<Request>(rt => {
                    rt.Property(r => r.Total).HasColumnType("decimal(11, 2)");
            });
            }

            
         

        public DbSet<User> Users { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Request> Requests { get; set; }

        public DbSet<RequestLine> RequestLines { get; set; }


        public PRSdb(DbContextOptions options) : base(options) {

        }

    }
}
