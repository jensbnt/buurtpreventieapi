using BuurtPreventie.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuurtPreventie.Data
{
    public class BuurtPreventieContext : DbContext
    {
        public DbSet<Gemeente> Gemeentes { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Opmerking> Opmerkingen { get; set; }

        public BuurtPreventieContext() { }

        public BuurtPreventieContext(DbContextOptions<BuurtPreventieContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = BuurtPreventieDB;Trusted_Connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zone>()
                .HasOne(z => z.Gemeente)
                .WithMany(g => g.Zones)
                .HasForeignKey(z => z.GemeenteId);

            modelBuilder.Entity<Opmerking>()
                .HasOne(o => o.Zone)
                .WithMany(z => z.Opmerkingen)
                .HasForeignKey(o => o.ZoneId);
        }
    }
}
