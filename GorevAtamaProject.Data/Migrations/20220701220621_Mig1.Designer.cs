﻿// <auto-generated />
using GorevAtamaProject.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GorevAtamaProject.Data.Migrations
{
    [DbContext(typeof(GorevAtamaProjectContext))]
    [Migration("20220701220621_Mig1")]
    partial class Mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("GorevAtamaProject.Entity.Islem", b =>
                {
                    b.Property<int>("IslemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IslemAd")
                        .HasColumnType("TEXT");

                    b.Property<string>("IslemZorluk")
                        .HasColumnType("TEXT");

                    b.HasKey("IslemID");

                    b.ToTable("Islems");
                });

            modelBuilder.Entity("GorevAtamaProject.Entity.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IslemID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PersonelAd")
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonelSoyad")
                        .HasColumnType("TEXT");

                    b.Property<int>("RolID")
                        .HasColumnType("INTEGER");

                    b.HasKey("PersonelID");

                    b.HasIndex("IslemID");

                    b.HasIndex("RolID");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("GorevAtamaProject.Entity.Rol", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RolAd")
                        .HasColumnType("TEXT");

                    b.HasKey("RolID");

                    b.ToTable("Rols");
                });

            modelBuilder.Entity("GorevAtamaProject.Entity.Personel", b =>
                {
                    b.HasOne("GorevAtamaProject.Entity.Islem", "Islem")
                        .WithMany("Personels")
                        .HasForeignKey("IslemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GorevAtamaProject.Entity.Rol", "Rol")
                        .WithMany("Personels")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Islem");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("GorevAtamaProject.Entity.Islem", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("GorevAtamaProject.Entity.Rol", b =>
                {
                    b.Navigation("Personels");
                });
#pragma warning restore 612, 618
        }
    }
}
