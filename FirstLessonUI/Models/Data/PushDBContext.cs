using FirstLessonUI.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace FirstLessonUI.Models.Data
{
    public class PushDBContext: DbContext
    {
        public PushDBContext(DbContextOptions options):base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Centers> Centers { get; set; }
        public DbSet<CenterImages> CenterImages { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<FirstLessonUI.Models.Entity.Region> Regions { get; set; }
        public DbSet<CityFitCenters> CityFitCenters { get; set; }
        public DbSet<SiteInfo> SiteInfos { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<CenterActivity> CenterActivities { get; set; }
        public DbSet<CentersPackage> CentersPackages { get; set; }
        public DbSet<CentersRegions> CentersRegions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //country -> city(one to many)
            modelBuilder.Entity<City>().HasOne(b => b.Country).
                WithMany(b => b.Cities).HasForeignKey(p => p.CountryId);
            //country -> region(one to many)
            modelBuilder.Entity<FirstLessonUI.Models.Entity.Region>().HasOne(b => b.Country).
                WithMany(b => b.Regions).HasForeignKey(p => p.CountryId);
            //country -> activity(one to many)
            modelBuilder.Entity<Activity>().HasOne(b => b.Country).
                WithMany(b => b.Activities).HasForeignKey(p => p.CountryId);
            //country -> package(one to many)
            modelBuilder.Entity<Package>().HasOne(b => b.Country).
                WithMany(b => b.Packages).HasForeignKey(p => p.CountryId);


            //centers <-> activity(many to many)
            modelBuilder.Entity<CenterActivity>()
                .HasKey(ca => new { ca.CenterId, ca.ActivityId });
            modelBuilder.Entity<CenterActivity>()
                .HasOne(ca => ca.Center)
                .WithMany(c => c.CenterActivities)
                .HasForeignKey(ca => ca.CenterId);
            modelBuilder.Entity<CenterActivity>()
                .HasOne(ca => ca.Activity)
                .WithMany(a => a.CenterActivities)
                .HasForeignKey(ca => ca.ActivityId);


            //centers <-> package(many to many)
            modelBuilder.Entity<CentersPackage>()
                .HasKey(cp => new { cp.CenterId, cp.PackageId });
            modelBuilder.Entity<CentersPackage>()
                .HasOne(cp => cp.Center)
                .WithMany(cp => cp.CenterPackages)
                .HasForeignKey(cp => cp.CenterId);
            modelBuilder.Entity<CentersPackage>()
                .HasOne(cp => cp.Packages)
                .WithMany(p => p.CenterPackages)
                .HasForeignKey(cp => cp.PackageId);


            //centers <-> city(many to many)
            modelBuilder.Entity<CityFitCenters>()
                .HasKey(c => new { c.CityId, c.CenterId });
            modelBuilder.Entity<CityFitCenters>()
                .HasOne(c => c.City)
                .WithMany(c => c.CityFitCenters)
                .HasForeignKey(c => c.CityId);
            modelBuilder.Entity<CityFitCenters>()
                .HasOne(c => c.Center)
                .WithMany(c => c.CityFitCenters)
                .HasForeignKey(c => c.CenterId);


            //city(one to many)
            modelBuilder.Entity<FirstLessonUI.Models.Entity.Region>().HasOne(b => b.City).
                WithMany(b => b.Regions).HasForeignKey(p => p.CityId);


            //centers <-> regions(many to many)
            modelBuilder.Entity<CentersRegions>()
                .HasKey(c => new { c.CenterId, c.RegionId });
            modelBuilder.Entity<CentersRegions>()
                .HasOne(c => c.Centers)
                .WithMany(c => c.CentersRegions)
                .HasForeignKey(c => c.CenterId);
            modelBuilder.Entity<CentersRegions>()
                .HasOne(c => c.Regions)
                .WithMany(c => c.CentersRegions)
                .HasForeignKey(c => c.RegionId);
        }
    }

}
