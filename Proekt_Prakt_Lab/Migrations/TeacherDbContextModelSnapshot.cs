﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proekt_Prakt_Lab.Database;

#nullable disable

namespace Proekt_Prakt_Lab.Migrations
{
    [DbContext(typeof(TeacherDbContext))]
    partial class TeacherDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proekt_Prakt_Lab.Models.Cafedra", b =>
                {
                    b.Property<int>("Cafedra_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cafedra_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cafedra_ID"));

                    b.Property<string>("Cafedra_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("c_cafedra_name");

                    b.Property<int?>("Main_Teacher_ID")
                        .HasColumnType("int")
                        .HasColumnName("main_teacher_id");

                    b.HasKey("Cafedra_ID")
                        .HasName("pk_cd_cafedra_cafedra_id");

                    b.HasIndex("Main_Teacher_ID")
                        .IsUnique()
                        .HasFilter("[main_teacher_id] IS NOT NULL");

                    b.HasIndex(new[] { "Main_Teacher_ID" }, "idx_cd_cafedra_fk_main_teacher_id");

                    b.ToTable("cd_cafedra", (string)null);
                });

            modelBuilder.Entity("Proekt_Prakt_Lab.Models.Degree", b =>
                {
                    b.Property<int>("Degree_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("degree_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Degree_ID"));

                    b.Property<string>("Degree_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("c_degree_name");

                    b.HasKey("Degree_ID")
                        .HasName("pk_cd_degree_degree_id");

                    b.ToTable("cd_degree", (string)null);
                });

            modelBuilder.Entity("Proekt_Prakt_Lab.Models.Discipline", b =>
                {
                    b.Property<int>("Discipline_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("discipline_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Discipline_ID"));

                    b.Property<int>("Discipline_Load_Hours")
                        .HasColumnType("int")
                        .HasColumnName("discipline_load_hours");

                    b.Property<string>("Discipline_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("c_discipline_name");

                    b.Property<int?>("Discipline_Teacher_ID")
                        .HasColumnType("int")
                        .HasColumnName("c_discipline_teacher_id");

                    b.HasKey("Discipline_ID")
                        .HasName("pk_cd_discipline_discipline_id");

                    b.HasIndex("Discipline_Teacher_ID")
                        .IsUnique()
                        .HasFilter("[c_discipline_teacher_id] IS NOT NULL");

                    b.HasIndex(new[] { "Discipline_Teacher_ID" }, "idx_cd_discipline_fk_discipline_teacher_id");

                    b.ToTable("cd_discipline", (string)null);
                });

            modelBuilder.Entity("Proekt_Prakt_Lab.Models.Load", b =>
                {
                    b.Property<int>("Load_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("load_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Load_ID"));

                    b.Property<int>("Hours")
                        .HasColumnType("int")
                        .HasColumnName("c_hours");

                    b.HasKey("Load_ID")
                        .HasName("pk_cd_load_load_id");

                    b.ToTable("cd_load", (string)null);
                });

            modelBuilder.Entity("Proekt_Prakt_Lab.Models.Position", b =>
                {
                    b.Property<int>("Position_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("position_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Position_ID"));

                    b.Property<string>("Position_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("c_position_name");

                    b.HasKey("Position_ID")
                        .HasName("pk_cd_position_position_id");

                    b.ToTable("cd_position", (string)null);
                });

            modelBuilder.Entity("Proekt_Prakt_Lab.Models.Teacher", b =>
                {
                    b.Property<int>("Teacher_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("teacher_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Teacher_ID"));

                    b.Property<int?>("Cafedra_ID")
                        .HasColumnType("int")
                        .HasColumnName("cafedra_id");

                    b.Property<int?>("Degree_ID")
                        .HasColumnType("int")
                        .HasColumnName("degree_id");

                    b.Property<int?>("Discipline_ID")
                        .HasColumnType("int")
                        .HasColumnName("discipline_id");

                    b.Property<int?>("Load_ID")
                        .HasColumnType("int")
                        .HasColumnName("load_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("c_teacher_name");

                    b.Property<int?>("Position_ID")
                        .HasColumnType("int")
                        .HasColumnName("position_id");

                    b.Property<string>("Second_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("c_teacher_second_name");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("c_teacher_surname");

                    b.HasKey("Teacher_ID")
                        .HasName("pk_cd_teacher_teacher_id");

                    b.HasIndex(new[] { "Cafedra_ID" }, "idx_cd_teacher_fk_cafedra_id");

                    b.HasIndex(new[] { "Degree_ID" }, "idx_cd_teacher_fk_degree_id");

                    b.HasIndex(new[] { "Discipline_ID" }, "idx_cd_teacher_fk_discipline_id");

                    b.HasIndex(new[] { "Load_ID" }, "idx_cd_teacher_fk_load_id");

                    b.HasIndex(new[] { "Position_ID" }, "idx_cd_teacher_fk_position_id");

                    b.ToTable("cd_teacher", (string)null);
                });

            modelBuilder.Entity("Proekt_Prakt_Lab.Models.Cafedra", b =>
                {
                    b.HasOne("Proekt_Prakt_Lab.Models.Teacher", "Main_teacher")
                        .WithOne()
                        .HasForeignKey("Proekt_Prakt_Lab.Models.Cafedra", "Main_Teacher_ID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_main_teacher_id");

                    b.Navigation("Main_teacher");
                });

            modelBuilder.Entity("Proekt_Prakt_Lab.Models.Discipline", b =>
                {
                    b.HasOne("Proekt_Prakt_Lab.Models.Teacher", "Discipline_Teacher_FIO")
                        .WithOne()
                        .HasForeignKey("Proekt_Prakt_Lab.Models.Discipline", "Discipline_Teacher_ID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_discipline_teacher_id");

                    b.Navigation("Discipline_Teacher_FIO");
                });

            modelBuilder.Entity("Proekt_Prakt_Lab.Models.Teacher", b =>
                {
                    b.HasOne("Proekt_Prakt_Lab.Models.Cafedra", "Cafedra")
                        .WithMany()
                        .HasForeignKey("Cafedra_ID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_cafedra_id");

                    b.HasOne("Proekt_Prakt_Lab.Models.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("Degree_ID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_degree_id");

                    b.HasOne("Proekt_Prakt_Lab.Models.Discipline", "Discipline")
                        .WithMany()
                        .HasForeignKey("Discipline_ID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_discipline_id");

                    b.HasOne("Proekt_Prakt_Lab.Models.Load", "Load")
                        .WithMany()
                        .HasForeignKey("Load_ID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_teacher_load_id");

                    b.HasOne("Proekt_Prakt_Lab.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("Position_ID")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_position_id");

                    b.Navigation("Cafedra");

                    b.Navigation("Degree");

                    b.Navigation("Discipline");

                    b.Navigation("Load");

                    b.Navigation("Position");
                });
#pragma warning restore 612, 618
        }
    }
}
