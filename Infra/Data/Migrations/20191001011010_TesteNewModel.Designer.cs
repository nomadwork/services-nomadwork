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
    [Migration("20191001011010_TesteNewModel")]
    partial class TesteNewModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.AddressModelData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Coutry")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(12,9)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(12,9)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Zipcode")
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.EstablishmentModelData", b =>
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

                    b.Property<short>("Wifi");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Establishment");
                });

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.PhotoModelData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long?>("EstablishmentModelDataId");

                    b.Property<string>("ExtensionFile");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<string>("NameFile");

                    b.Property<string>("UrlPhoto")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EstablishmentModelDataId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Nomadwork.Infra.Models.UserLogin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Email");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.EstablishmentModelData", b =>
                {
                    b.HasOne("Nomadwork.Infra.Data.ObjectData.AddressModelData", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nomadwork.Infra.Data.ObjectData.PhotoModelData", b =>
                {
                    b.HasOne("Nomadwork.Infra.Data.ObjectData.EstablishmentModelData")
                        .WithMany("Photos")
                        .HasForeignKey("EstablishmentModelDataId");
                });
#pragma warning restore 612, 618
        }
    }
}
