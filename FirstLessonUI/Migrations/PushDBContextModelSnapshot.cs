﻿// <auto-generated />
using System;
using FirstLessonUI.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstLessonUI.Migrations
{
    [DbContext(typeof(PushDBContext))]
    partial class PushDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionAZE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionENG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionRUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAZE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameENG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAZE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameENG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.CenterActivity", b =>
                {
                    b.Property<int>("CenterId")
                        .HasColumnType("int");

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.HasKey("CenterId", "ActivityId");

                    b.HasIndex("ActivityId");

                    b.ToTable("CenterActivities");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.CenterImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CenterId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.ToTable("CenterImages");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Centers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionENG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionRUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameENG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoteENG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoteRUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Centers");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.CentersPackage", b =>
                {
                    b.Property<int>("CenterId")
                        .HasColumnType("int");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.HasKey("CenterId", "PackageId");

                    b.HasIndex("PackageId");

                    b.ToTable("CentersPackages");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.CentersRegions", b =>
                {
                    b.Property<int>("CenterId")
                        .HasColumnType("int");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("CenterId", "RegionId");

                    b.HasIndex("RegionId");

                    b.ToTable("CentersRegions");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAZE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameENG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.CityFitCenters", b =>
                {
                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CenterId")
                        .HasColumnType("int");

                    b.HasKey("CityId", "CenterId");

                    b.HasIndex("CenterId");

                    b.ToTable("CityFitCenters");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionAZE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionENG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionRUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAZE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameENG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAZE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameENG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.SiteInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("FavIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAZE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameENG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SiteInfos");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Activity", b =>
                {
                    b.HasOne("FirstLessonUI.Models.Entity.Country", "Country")
                        .WithMany("Activities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.CenterActivity", b =>
                {
                    b.HasOne("FirstLessonUI.Models.Entity.Activity", "Activity")
                        .WithMany("CenterActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirstLessonUI.Models.Entity.Centers", "Center")
                        .WithMany("CenterActivities")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("Center");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.CenterImages", b =>
                {
                    b.HasOne("FirstLessonUI.Models.Entity.Centers", "Center")
                        .WithMany("Images")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Centers", b =>
                {
                    b.HasOne("FirstLessonUI.Models.Entity.Country", "Country")
                        .WithMany("Centers")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.CentersPackage", b =>
                {
                    b.HasOne("FirstLessonUI.Models.Entity.Centers", "Center")
                        .WithMany("CenterPackages")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirstLessonUI.Models.Entity.Package", "Packages")
                        .WithMany("CenterPackages")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");

                    b.Navigation("Packages");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.CentersRegions", b =>
                {
                    b.HasOne("FirstLessonUI.Models.Entity.Centers", "Centers")
                        .WithMany("CentersRegions")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirstLessonUI.Models.Entity.Region", "Regions")
                        .WithMany("CentersRegions")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Centers");

                    b.Navigation("Regions");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.City", b =>
                {
                    b.HasOne("FirstLessonUI.Models.Entity.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.CityFitCenters", b =>
                {
                    b.HasOne("FirstLessonUI.Models.Entity.Centers", "Center")
                        .WithMany("CityFitCenters")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirstLessonUI.Models.Entity.City", "City")
                        .WithMany("CityFitCenters")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Center");

                    b.Navigation("City");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Package", b =>
                {
                    b.HasOne("FirstLessonUI.Models.Entity.Country", "Country")
                        .WithMany("Packages")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Region", b =>
                {
                    b.HasOne("FirstLessonUI.Models.Entity.City", "City")
                        .WithMany("Regions")
                        .HasForeignKey("CityId");

                    b.HasOne("FirstLessonUI.Models.Entity.Country", "Country")
                        .WithMany("Regions")
                        .HasForeignKey("CountryId");

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Activity", b =>
                {
                    b.Navigation("CenterActivities");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Centers", b =>
                {
                    b.Navigation("CenterActivities");

                    b.Navigation("CenterPackages");

                    b.Navigation("CentersRegions");

                    b.Navigation("CityFitCenters");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.City", b =>
                {
                    b.Navigation("CityFitCenters");

                    b.Navigation("Regions");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Country", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Centers");

                    b.Navigation("Cities");

                    b.Navigation("Packages");

                    b.Navigation("Regions");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Package", b =>
                {
                    b.Navigation("CenterPackages");
                });

            modelBuilder.Entity("FirstLessonUI.Models.Entity.Region", b =>
                {
                    b.Navigation("CentersRegions");
                });
#pragma warning restore 612, 618
        }
    }
}
