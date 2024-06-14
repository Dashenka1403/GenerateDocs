﻿// <auto-generated />
using System;
using GenerateDocs.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GenerateDocs.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GenerateDocs.Models.Disciplines.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeDiscipline")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("EducationProgrammId")
                        .HasColumnType("integer");

                    b.Property<string>("Goal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EducationProgrammId");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("GenerateDocs.Models.Disciplines.DisciplineInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeCompetence")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("DisciplineId")
                        .HasColumnType("integer");

                    b.Property<string>("Knowledge")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ownership")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Skill")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.ToTable("DisciplineInfos");
                });

            modelBuilder.Entity("GenerateDocs.Models.Disciplines.LaborIntensity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("DisciplineId")
                        .HasColumnType("integer");

                    b.Property<string>("IdSem")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.ToTable("LaborIntensities");
                });

            modelBuilder.Entity("GenerateDocs.Models.EducationProgramms.CompetenceInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeCompetence")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("EducationProgrammId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EducationProgrammId");

                    b.ToTable("CompetenceInfos");
                });

            modelBuilder.Entity("GenerateDocs.Models.EducationProgramms.EducationProgramm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EducationProgramms");
                });

            modelBuilder.Entity("GenerateDocs.Models.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Middlename")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GenerateDocs.Models.Disciplines.Discipline", b =>
                {
                    b.HasOne("GenerateDocs.Models.EducationProgramms.EducationProgramm", null)
                        .WithMany("Disciplines")
                        .HasForeignKey("EducationProgrammId");
                });

            modelBuilder.Entity("GenerateDocs.Models.Disciplines.DisciplineInfo", b =>
                {
                    b.HasOne("GenerateDocs.Models.Disciplines.Discipline", null)
                        .WithMany("DisciplineInfos")
                        .HasForeignKey("DisciplineId");
                });

            modelBuilder.Entity("GenerateDocs.Models.Disciplines.LaborIntensity", b =>
                {
                    b.HasOne("GenerateDocs.Models.Disciplines.Discipline", null)
                        .WithMany("LaborIntensities")
                        .HasForeignKey("DisciplineId");
                });

            modelBuilder.Entity("GenerateDocs.Models.EducationProgramms.CompetenceInfo", b =>
                {
                    b.HasOne("GenerateDocs.Models.EducationProgramms.EducationProgramm", null)
                        .WithMany("Competences")
                        .HasForeignKey("EducationProgrammId");
                });

            modelBuilder.Entity("GenerateDocs.Models.EducationProgramms.EducationProgramm", b =>
                {
                    b.HasOne("GenerateDocs.Models.Users.User", null)
                        .WithMany("EducationProgramms")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("GenerateDocs.Models.Disciplines.Discipline", b =>
                {
                    b.Navigation("DisciplineInfos");

                    b.Navigation("LaborIntensities");
                });

            modelBuilder.Entity("GenerateDocs.Models.EducationProgramms.EducationProgramm", b =>
                {
                    b.Navigation("Competences");

                    b.Navigation("Disciplines");
                });

            modelBuilder.Entity("GenerateDocs.Models.Users.User", b =>
                {
                    b.Navigation("EducationProgramms");
                });
#pragma warning restore 612, 618
        }
    }
}