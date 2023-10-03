﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.HealthClinic.Tarde.Contexts;

#nullable disable

namespace WebApi.HealthClinic.Tarde.Migrations
{
    [DbContext(typeof(HealthContext))]
    partial class HealthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Clinica", b =>
                {
                    b.Property<Guid>("IdClinica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("VARCHAR(14)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<TimeOnly?>("HoraDeEncerramento")
                        .IsRequired()
                        .HasColumnType("TIME");

                    b.Property<TimeOnly?>("HoraDeInicio")
                        .IsRequired()
                        .HasColumnType("TIME");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdClinica");

                    b.HasIndex("CNPJ")
                        .IsUnique();

                    b.ToTable("Clinica");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Comentario", b =>
                {
                    b.Property<Guid>("IdComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Feedbacks")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IdConsulta")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdComentario");

                    b.HasIndex("IdConsulta");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Consulta", b =>
                {
                    b.Property<Guid>("IdConsulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataConsulta")
                        .IsRequired()
                        .HasColumnType("DATETIME");

                    b.Property<TimeOnly?>("HorarioConsulta")
                        .IsRequired()
                        .HasColumnType("TIME");

                    b.Property<Guid>("IdClinica")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMedico")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPaciente")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Prontuário")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Situacao")
                        .IsRequired()
                        .HasColumnType("BIT");

                    b.HasKey("IdConsulta");

                    b.HasIndex("IdClinica");

                    b.HasIndex("IdMedico");

                    b.HasIndex("IdPaciente");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Especialidades", b =>
                {
                    b.Property<Guid>("IdEspecialidades")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdEspecialidades");

                    b.HasIndex("Titulo")
                        .IsUnique();

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Medico", b =>
                {
                    b.Property<Guid>("IdMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<Guid>("IdEspecialidades")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdMedico");

                    b.HasIndex("CRM")
                        .IsUnique();

                    b.HasIndex("IdEspecialidades");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Paciente", b =>
                {
                    b.Property<Guid>("IdPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("VARCHAR(8)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("VARCHAR(11)");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("VARCHAR(9)");

                    b.HasKey("IdPaciente");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("IdUsuario");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.TipoUsuario", b =>
                {
                    b.Property<Guid>("IdTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdTipoUsuario");

                    b.HasIndex("Titulo")
                        .IsUnique();

                    b.ToTable("TipoUsuario");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<Guid>("IdTipoUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("CHAR(60)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("IdTipoUsuario");

                    b.HasIndex("Telefone")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Comentario", b =>
                {
                    b.HasOne("WebApi.HealthClinic.Tarde.Domains.Consulta", "Consulta")
                        .WithMany()
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Consulta", b =>
                {
                    b.HasOne("WebApi.HealthClinic.Tarde.Domains.Clinica", "Clinica")
                        .WithMany()
                        .HasForeignKey("IdClinica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.HealthClinic.Tarde.Domains.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("IdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.HealthClinic.Tarde.Domains.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinica");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Medico", b =>
                {
                    b.HasOne("WebApi.HealthClinic.Tarde.Domains.Especialidades", "Especialidades")
                        .WithMany()
                        .HasForeignKey("IdEspecialidades")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.HealthClinic.Tarde.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidades");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Paciente", b =>
                {
                    b.HasOne("WebApi.HealthClinic.Tarde.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebApi.HealthClinic.Tarde.Domains.Usuario", b =>
                {
                    b.HasOne("WebApi.HealthClinic.Tarde.Domains.TipoUsuario", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("IdTipoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
