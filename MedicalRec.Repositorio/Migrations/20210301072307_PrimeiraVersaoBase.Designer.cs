﻿// <auto-generated />
using MedicalRec.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedicalRec.Repositorio.Migrations
{
    [DbContext(typeof(MedicalRecContexto))]
    [Migration("20210301072307_PrimeiraVersaoBase")]
    partial class PrimeiraVersaoBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MedicalRec.Dominio.Entidades.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .HasMaxLength(50);

                    b.Property<string>("CEP")
                        .IsRequired();

                    b.Property<string>("Cidade")
                        .HasMaxLength(50);

                    b.Property<string>("Estado")
                        .HasMaxLength(20);

                    b.Property<string>("Logradouro")
                        .HasMaxLength(70);

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("MedicalRec.Dominio.Entidades.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("MedicalRec.Dominio.Entidades.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CRM")
                        .HasMaxLength(9);

                    b.Property<int>("EnderecoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("TelCel")
                        .HasMaxLength(20);

                    b.Property<string>("TelFixo")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("MedicalRec.Dominio.Entidades.MedicoEspecialidade", b =>
                {
                    b.Property<int>("MedicoId");

                    b.Property<int>("EspecialidadeId");

                    b.HasKey("MedicoId", "EspecialidadeId");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("MedicoEspecialidades");
                });

            modelBuilder.Entity("MedicalRec.Dominio.Entidades.MedicoEspecialidade", b =>
                {
                    b.HasOne("MedicalRec.Dominio.Entidades.Especialidade", "Especialidade")
                        .WithMany("MedicoEspecialidades")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MedicalRec.Dominio.Entidades.Medico", "Medico")
                        .WithMany("MedicoEspecialidades")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
