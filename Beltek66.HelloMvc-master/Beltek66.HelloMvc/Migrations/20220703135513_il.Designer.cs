﻿// <auto-generated />
using Beltek66.HelloMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Beltek66.HelloMvc.Migrations
{
    [DbContext(typeof(OkulDbContext))]
    [Migration("20220703135513_il")]
    partial class il
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Beltek66.HelloMvc.Models.Ders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DersAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgretmenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("Beltek66.HelloMvc.Models.Ogrenci", b =>
                {
                    b.Property<int>("Ogrenciid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Sinifid")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<byte>("Yas")
                        .HasColumnType("tinyint");

                    b.HasKey("Ogrenciid");

                    b.HasIndex("Sinifid");

                    b.ToTable("tblOgrenciler");
                });

            modelBuilder.Entity("Beltek66.HelloMvc.Models.Ogretmen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bolum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ogretmen");
                });

            modelBuilder.Entity("Beltek66.HelloMvc.Models.Sinif", b =>
                {
                    b.Property<int>("Sinifid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Sinifad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sinifid");

                    b.ToTable("Siniflar");
                });

            modelBuilder.Entity("DersOgretmen", b =>
                {
                    b.Property<int>("DerslerId")
                        .HasColumnType("int");

                    b.Property<int>("OgretmenlerId")
                        .HasColumnType("int");

                    b.HasKey("DerslerId", "OgretmenlerId");

                    b.HasIndex("OgretmenlerId");

                    b.ToTable("DersOgretmen");
                });

            modelBuilder.Entity("Beltek66.HelloMvc.Models.Ogrenci", b =>
                {
                    b.HasOne("Beltek66.HelloMvc.Models.Sinif", "Sinifi")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("Sinifid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinifi");
                });

            modelBuilder.Entity("DersOgretmen", b =>
                {
                    b.HasOne("Beltek66.HelloMvc.Models.Ders", null)
                        .WithMany()
                        .HasForeignKey("DerslerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Beltek66.HelloMvc.Models.Ogretmen", null)
                        .WithMany()
                        .HasForeignKey("OgretmenlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Beltek66.HelloMvc.Models.Sinif", b =>
                {
                    b.Navigation("Ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}
