﻿// <auto-generated />
using System;
using Easypark.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Easypark.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221029165908_EstacionamentosMigration")]
    partial class EstacionamentosMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Easypark.Models.Cliente", b =>
                {
                    b.Property<int>("cliente_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CNPJ")
                        .HasColumnType("int");

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("modeloCarro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placaCarro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoCarro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cliente_id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Easypark.Models.EnderecoModel", b =>
                {
                    b.Property<int>("codigoEstacionamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nomeBairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeCidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeEstado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeLogradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.HasKey("codigoEstacionamento");

                    b.ToTable("EnderecoModel");
                });

            modelBuilder.Entity("Easypark.Models.Estacionamento", b =>
                {
                    b.Property<int>("codigoEstacionamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.Property<int?>("enderecocodigoEstacionamento")
                        .HasColumnType("int");

                    b.Property<bool>("lavaJato")
                        .HasColumnType("bit");

                    b.Property<string>("nomeEstacionamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("vagaCarroEletricocodigoVagasDisponiveis")
                        .HasColumnType("int");

                    b.Property<int?>("vagaDeficientecodigoVagasDisponiveis")
                        .HasColumnType("int");

                    b.Property<int?>("vagaIdosocodigoVagasDisponiveis")
                        .HasColumnType("int");

                    b.Property<int?>("vagaRegularcodigoVagasDisponiveis")
                        .HasColumnType("int");

                    b.Property<int?>("vagacodigoVagasDisponiveis")
                        .HasColumnType("int");

                    b.HasKey("codigoEstacionamento");

                    b.HasIndex("enderecocodigoEstacionamento");

                    b.HasIndex("vagaCarroEletricocodigoVagasDisponiveis");

                    b.HasIndex("vagaDeficientecodigoVagasDisponiveis");

                    b.HasIndex("vagaIdosocodigoVagasDisponiveis");

                    b.HasIndex("vagaRegularcodigoVagasDisponiveis");

                    b.HasIndex("vagacodigoVagasDisponiveis");

                    b.ToTable("Estacionamentos");
                });

            modelBuilder.Entity("Easypark.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Easypark.Models.Vaga", b =>
                {
                    b.Property<int>("codVaga")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cliente_id")
                        .HasColumnType("int");

                    b.Property<bool>("preenchido")
                        .HasColumnType("bit");

                    b.Property<string>("tipoVaga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codVaga");

                    b.HasIndex("cliente_id");

                    b.ToTable("Vagas");
                });

            modelBuilder.Entity("Easypark.Models.VagaModel", b =>
                {
                    b.Property<int>("codigoVagasDisponiveis")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("codigoEstacionamento")
                        .HasColumnType("int");

                    b.HasKey("codigoVagasDisponiveis");

                    b.ToTable("VagaModel");
                });

            modelBuilder.Entity("Easypark.Models.Estacionamento", b =>
                {
                    b.HasOne("Easypark.Models.EnderecoModel", "endereco")
                        .WithMany()
                        .HasForeignKey("enderecocodigoEstacionamento");

                    b.HasOne("Easypark.Models.VagaModel", "vagaCarroEletrico")
                        .WithMany()
                        .HasForeignKey("vagaCarroEletricocodigoVagasDisponiveis");

                    b.HasOne("Easypark.Models.VagaModel", "vagaDeficiente")
                        .WithMany()
                        .HasForeignKey("vagaDeficientecodigoVagasDisponiveis");

                    b.HasOne("Easypark.Models.VagaModel", "vagaIdoso")
                        .WithMany()
                        .HasForeignKey("vagaIdosocodigoVagasDisponiveis");

                    b.HasOne("Easypark.Models.VagaModel", "vagaRegular")
                        .WithMany()
                        .HasForeignKey("vagaRegularcodigoVagasDisponiveis");

                    b.HasOne("Easypark.Models.VagaModel", "vaga")
                        .WithMany()
                        .HasForeignKey("vagacodigoVagasDisponiveis");

                    b.Navigation("endereco");

                    b.Navigation("vaga");

                    b.Navigation("vagaCarroEletrico");

                    b.Navigation("vagaDeficiente");

                    b.Navigation("vagaIdoso");

                    b.Navigation("vagaRegular");
                });

            modelBuilder.Entity("Easypark.Models.Vaga", b =>
                {
                    b.HasOne("Easypark.Models.Cliente", "Cliente")
                        .WithMany("Vagas")
                        .HasForeignKey("cliente_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Easypark.Models.Cliente", b =>
                {
                    b.Navigation("Vagas");
                });
#pragma warning restore 612, 618
        }
    }
}