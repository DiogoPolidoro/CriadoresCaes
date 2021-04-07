﻿// <auto-generated />
using System;
using CriadoresCaes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CriadoresCaes.Migrations
{
    [DbContext(typeof(CriadoresCaesDB))]
    [Migration("20210407120909_Nome Criador Obrigatorio")]
    partial class NomeCriadorObrigatorio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CriadoresCaes.Models.Caes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("LOP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RacaFK")
                        .HasColumnType("int");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RacaFK");

                    b.ToTable("Caes");
                });

            modelBuilder.Entity("CriadoresCaes.Models.CriadorCaes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaesFK")
                        .HasColumnType("int");

                    b.Property<int>("CriadorFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CaesFK");

                    b.HasIndex("CriadorFK");

                    b.ToTable("CriadoresCaes");
                });

            modelBuilder.Entity("CriadoresCaes.Models.Criadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeComercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telemovel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Criadores");
                });

            modelBuilder.Entity("CriadoresCaes.Models.Fotografias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaoFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFoto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalFoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CaoFK");

                    b.ToTable("Fotografias");
                });

            modelBuilder.Entity("CriadoresCaes.Models.Racas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Racas");
                });

            modelBuilder.Entity("CriadoresCaes.Models.Caes", b =>
                {
                    b.HasOne("CriadoresCaes.Models.Racas", "Raca")
                        .WithMany("ListaDeCaes")
                        .HasForeignKey("RacaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Raca");
                });

            modelBuilder.Entity("CriadoresCaes.Models.CriadorCaes", b =>
                {
                    b.HasOne("CriadoresCaes.Models.Caes", "Cao")
                        .WithMany("ListaCriadores")
                        .HasForeignKey("CaesFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CriadoresCaes.Models.Criadores", "Criador")
                        .WithMany("ListaDeCaes")
                        .HasForeignKey("CriadorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cao");

                    b.Navigation("Criador");
                });

            modelBuilder.Entity("CriadoresCaes.Models.Fotografias", b =>
                {
                    b.HasOne("CriadoresCaes.Models.Caes", "Cao")
                        .WithMany("ListaDeFotografias")
                        .HasForeignKey("CaoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cao");
                });

            modelBuilder.Entity("CriadoresCaes.Models.Caes", b =>
                {
                    b.Navigation("ListaCriadores");

                    b.Navigation("ListaDeFotografias");
                });

            modelBuilder.Entity("CriadoresCaes.Models.Criadores", b =>
                {
                    b.Navigation("ListaDeCaes");
                });

            modelBuilder.Entity("CriadoresCaes.Models.Racas", b =>
                {
                    b.Navigation("ListaDeCaes");
                });
#pragma warning restore 612, 618
        }
    }
}
