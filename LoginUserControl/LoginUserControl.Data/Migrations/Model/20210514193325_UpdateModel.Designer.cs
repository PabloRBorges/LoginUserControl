﻿// <auto-generated />
using System;
using LoginUserControl.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoginUserControl.Data.Migrations.Model
{
    [DbContext(typeof(ModelContext))]
    [Migration("20210514193325_UpdateModel")]
    partial class UpdateModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoginUserControl.Core.Entities.Bomba", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("ContratoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Contrato_FK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataFabricacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diametro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoTubo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vazao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContratoId");

                    b.ToTable("Bombas");
                });

            modelBuilder.Entity("LoginUserControl.Core.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalGPS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsavel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("LoginUserControl.Core.Entities.Contrato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("ClienteFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Validade")
                        .HasColumnType("datetime2");

                    b.Property<string>("ValorContrato")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteFK");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("LoginUserControl.Core.Entities.DadoRecebido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("DadosJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataUpdate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdPlaca")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("DadosRecebidos");
                });

            modelBuilder.Entity("LoginUserControl.Core.Entities.Placa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<bool>("BloqueioContrato")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ContratoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataFabricacao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EmUso")
                        .HasColumnType("bit");

                    b.Property<string>("MacAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersaoCodigo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContratoId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("LoginUserControl.Core.Entities.Sensor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("ContratoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DataCompra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmUso")
                        .HasColumnType("bit");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vazao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContratoId");

                    b.ToTable("Sensor");
                });

            modelBuilder.Entity("LoginUserControl.Core.Entities.Bomba", b =>
                {
                    b.HasOne("LoginUserControl.Core.Entities.Contrato", null)
                        .WithMany("Bombas")
                        .HasForeignKey("ContratoId");
                });

            modelBuilder.Entity("LoginUserControl.Core.Entities.Contrato", b =>
                {
                    b.HasOne("LoginUserControl.Core.Entities.Cliente", null)
                        .WithMany("Contratos")
                        .HasForeignKey("ClienteFK");
                });

            modelBuilder.Entity("LoginUserControl.Core.Entities.Placa", b =>
                {
                    b.HasOne("LoginUserControl.Core.Entities.Contrato", null)
                        .WithMany("Placas")
                        .HasForeignKey("ContratoId");
                });

            modelBuilder.Entity("LoginUserControl.Core.Entities.Sensor", b =>
                {
                    b.HasOne("LoginUserControl.Core.Entities.Contrato", null)
                        .WithMany("Sensores")
                        .HasForeignKey("ContratoId");
                });

            modelBuilder.Entity("LoginUserControl.Core.Entities.Cliente", b =>
                {
                    b.Navigation("Contratos");
                });

            modelBuilder.Entity("LoginUserControl.Core.Entities.Contrato", b =>
                {
                    b.Navigation("Bombas");

                    b.Navigation("Placas");

                    b.Navigation("Sensores");
                });
#pragma warning restore 612, 618
        }
    }
}
