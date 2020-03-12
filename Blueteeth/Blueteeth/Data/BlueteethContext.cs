using Blueteeth.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blueteeth.Data
{
    public class BlueteethContext : DbContext
    {
        public DbSet<BrushingHistory> BrushingHistories { get; set; }

        string path;

        public BlueteethContext(string path) : base()
        {
            this.path = path;

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder != null && !optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Filename={path}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder != null)
            {
                modelBuilder.Entity<BrushingHistory>()
                    .HasKey(bh => bh.Id);

                modelBuilder.Entity<BrushingHistory>()
                    .HasOne(bh => bh.Account)
                    .WithMany(a => a.BrushingHistories)
                    .HasForeignKey(bh => bh.AccountId)
                    .OnDelete(DeleteBehavior.Restrict);
            }

        }
    }
}
