﻿// <auto-generated />
using System;
using EFCore.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.WebAPI.Migrations
{
    [DbContext(typeof(HeroiContext))]
    partial class HeroiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore.WebAPI.Model.Arma", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("HeroiId")
                        .HasColumnType("int");

                    b.Property<int?>("IdentidadeSecretaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HeroiId");

                    b.HasIndex("IdentidadeSecretaId");

                    b.ToTable("Armas");
                });

            modelBuilder.Entity("EFCore.WebAPI.Model.Batalha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DtFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DtInicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HeroiBatalhaBatalhaId")
                        .HasColumnType("int");

                    b.Property<int?>("HeroiBatalhaHeroiId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HeroiBatalhaBatalhaId", "HeroiBatalhaHeroiId");

                    b.ToTable("Batalhas");
                });

            modelBuilder.Entity("EFCore.WebAPI.Model.Heroi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HeroiBatalhaBatalhaId")
                        .HasColumnType("int");

                    b.Property<int?>("HeroiBatalhaHeroiId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HeroiBatalhaBatalhaId", "HeroiBatalhaHeroiId");

                    b.ToTable("Herois");
                });

            modelBuilder.Entity("EFCore.WebAPI.Model.HeroiBatalha", b =>
                {
                    b.Property<int>("BatalhaId")
                        .HasColumnType("int");

                    b.Property<int>("HeroiId")
                        .HasColumnType("int");

                    b.Property<int?>("IdentidadeSecretaId")
                        .HasColumnType("int");

                    b.HasKey("BatalhaId", "HeroiId");

                    b.HasIndex("IdentidadeSecretaId");

                    b.ToTable("HeroisBatalhas");
                });

            modelBuilder.Entity("EFCore.WebAPI.Model.IdentidadeSecreta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdentidadeId")
                        .HasColumnType("int");

                    b.Property<string>("NomeReal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentidadeId");

                    b.ToTable("IdentidadesSecretas");
                });

            modelBuilder.Entity("EFCore.WebAPI.Model.Arma", b =>
                {
                    b.HasOne("EFCore.WebAPI.Model.Heroi", "Herois")
                        .WithMany()
                        .HasForeignKey("HeroiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore.WebAPI.Model.IdentidadeSecreta", null)
                        .WithMany("Armas")
                        .HasForeignKey("IdentidadeSecretaId");
                });

            modelBuilder.Entity("EFCore.WebAPI.Model.Batalha", b =>
                {
                    b.HasOne("EFCore.WebAPI.Model.HeroiBatalha", null)
                        .WithMany("Batalhas")
                        .HasForeignKey("HeroiBatalhaBatalhaId", "HeroiBatalhaHeroiId");
                });

            modelBuilder.Entity("EFCore.WebAPI.Model.Heroi", b =>
                {
                    b.HasOne("EFCore.WebAPI.Model.HeroiBatalha", null)
                        .WithMany("Herois")
                        .HasForeignKey("HeroiBatalhaBatalhaId", "HeroiBatalhaHeroiId");
                });

            modelBuilder.Entity("EFCore.WebAPI.Model.HeroiBatalha", b =>
                {
                    b.HasOne("EFCore.WebAPI.Model.IdentidadeSecreta", null)
                        .WithMany("HeroisBatalhas")
                        .HasForeignKey("IdentidadeSecretaId");
                });

            modelBuilder.Entity("EFCore.WebAPI.Model.IdentidadeSecreta", b =>
                {
                    b.HasOne("EFCore.WebAPI.Model.IdentidadeSecreta", "Identidade")
                        .WithMany()
                        .HasForeignKey("IdentidadeId");
                });
#pragma warning restore 612, 618
        }
    }
}
