﻿// <auto-generated />
using Easypark.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Easypark.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Easypark.Models.Vaga", b =>
                {
                    b.Property<int>("codVaga")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cliente_id")
                        .HasColumnType("int");

                    b.Property<int>("preenchido")
                        .HasColumnType("int");

                    b.Property<string>("tipoVaga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codVaga");

                    b.HasIndex("cliente_id");

                    b.ToTable("Vagas");
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
