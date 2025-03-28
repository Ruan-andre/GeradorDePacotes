﻿// <auto-generated />
using GeradorDePacotes.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeradorDePacotes.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240910024802_AddColumn-LastSelectedFile")]
    partial class AddColumnLastSelectedFile
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("GeradorDePacotes.Database.Entities.FileNameOutputLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LastSelected")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameFile")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FileNameOutputLogs");
                });

            modelBuilder.Entity("GeradorDePacotes.Database.Entities.FilesToDelete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Disconsider")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameFile")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FilesToDelete");
                });

            modelBuilder.Entity("GeradorDePacotes.Database.Entities.FilesToVerify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Disconsider")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameFile")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FilesToVerify");
                });

            modelBuilder.Entity("GeradorDePacotes.Database.Entities.FoldersToDelete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Disconsider")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameFolder")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FoldersToDelete");
                });

            modelBuilder.Entity("GeradorDePacotes.Database.Entities.FoldersToVerify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Disconsider")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameFolder")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FoldersToVerify");
                });

            modelBuilder.Entity("GeradorDePacotes.Database.Entities.ParKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ParKeys");
                });
#pragma warning restore 612, 618
        }
    }
}
