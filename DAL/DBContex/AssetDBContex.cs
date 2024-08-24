using DAL.Model.Implementation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContex
{
    public class AssetDBContex : DbContext
    {
        public AssetDBContex(DbContextOptions<AssetDBContex> options)
            : base(options)
        {
        }

        public DbSet<BDProject> Projects { get; set; }
        public DbSet<BuildingGroup> BuildingGroups { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Element> Elements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         


            base.OnModelCreating(modelBuilder);

            // Project to BuildingGroup relationship
            modelBuilder.Entity<BDProject>()
                .HasMany(p => p.BuildingGroups)
                .WithOne(bg => bg.Project)
                .HasForeignKey(bg => bg.ProjectId)
                .OnDelete(DeleteBehavior.Cascade); // Configure cascading delete behavior

            // BuildingGroup to Building relationship
            modelBuilder.Entity<BuildingGroup>()
                .HasMany(bg => bg.Buildings)
                .WithOne(b => b.BuildingGroup)
                .HasForeignKey(b => b.BuildingGroupId)
                .OnDelete(DeleteBehavior.Cascade); // Configure cascading delete behavior

            // Building to Room relationship
            modelBuilder.Entity<Building>()
                .HasMany(b => b.Rooms)
                .WithOne(r => r.Building)
                .HasForeignKey(r => r.BuildingId)
                .OnDelete(DeleteBehavior.Cascade); // Configure cascading delete behavior

            // Room to Element relationship
            modelBuilder.Entity<Room>()
                .HasMany(r => r.Elements)
                .WithOne(e => e.Room)
                .HasForeignKey(e => e.RoomId)
                .OnDelete(DeleteBehavior.Cascade); // Configure cascading delete behavior

            // Additional configuration can go here
        }
    }
}
