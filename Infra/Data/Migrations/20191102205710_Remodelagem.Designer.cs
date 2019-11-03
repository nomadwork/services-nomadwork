﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nomadwork.Infra.Data.Contexts;

namespace Nomadwork.Infra.Data.Migrations
{
    [DbContext(typeof(NomadworkDbContext))]
    [Migration("20191102205710_Remodelagem")]
    partial class Remodelagem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.AddressModelData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Coutry")
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(12,9)");

                    b.Property<decimal>("LatitudePrecision")
                        .HasColumnType("decimal(3,1)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(12,9)");

                    b.Property<decimal>("LongitudePricision")
                        .HasColumnType("decimal(3,1)");

                    b.Property<string>("Number")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("State")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Street")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Zipcode")
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.EstablishmmentModelData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long>("AddressId");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<short>("Noise");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(20)");

                    b.Property<short>("Plug");

                    b.Property<string>("TimeClose")
                        .HasColumnType("char(5)");

                    b.Property<string>("TimeOpen")
                        .HasColumnType("char(5)");

                    b.Property<long>("UserAdminId");

                    b.Property<short>("Wifi");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Establishment");
                });

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.EstablishmmentSugestionModelData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(12,9)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(12,9)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<short>("Noise");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(20)");

                    b.Property<short>("Plug");

                    b.Property<DateTime>("TimeClose");

                    b.Property<DateTime>("TimeOpen");

                    b.Property<long>("UserSugestedId");

                    b.Property<short>("Wifi");

                    b.HasKey("Id");

                    b.ToTable("Establishimment_Sugestions");
                });

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.PhotoModelData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long?>("EstablishmmentModelDataId");

                    b.Property<string>("ExtensionFile");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<string>("NameFile");

                    b.Property<string>("UrlPhoto")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EstablishmmentModelDataId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.UserModelData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<bool>("Admin");

                    b.Property<DateTime>("Dateborn")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Gender");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.EstablishmmentModelData", b =>
                {
                    b.HasOne("Nomadwork.Infra.Data.ObjectData.AddressModelData", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.PhotoModelData", b =>
                {
                    b.HasOne("Nomadwork.Infra.Data.ObjectData.EstablishmmentModelData")
                        .WithMany("Photos")
                        .HasForeignKey("EstablishmmentModelDataId");
                });
#pragma warning restore 612, 618
        }
    }
}