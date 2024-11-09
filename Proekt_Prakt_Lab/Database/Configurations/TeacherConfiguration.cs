using Proekt_Prakt_Lab.Models;
using Proekt_Prakt_Lab.Database.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Proekt_Prakt_Lab.Database.Configurations
{
    public class TeacherConfiguration:IEntityTypeConfiguration<Teacher> 
    {
        private const string TableName = "cd_teacher";
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .HasKey(p=>p.Teacher_ID)
                .HasName($"pk_{TableName}_teacher_id");
            builder.Property(p => p.Teacher_ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("teacher_id");
            builder.Property(p => p.Name)
                .HasColumnName("c_teacher_name")
                .HasColumnType(ColumnType.String)
                .HasMaxLength(100);
            builder.Property(p=>p.Surname)
                .HasColumnName("c_teacher_surname")
                .HasColumnType(ColumnType.String)
                .HasMaxLength(100);
            builder.Property(p=>p.Second_Name)
                .HasColumnName("c_teacher_second_name")
                .HasColumnType(ColumnType.String)
                .HasMaxLength(100);

            builder.Property(p => p.Cafedra_ID)
                .HasColumnName("cafedra_id")
                .HasColumnType(ColumnType.Int);
            builder.HasOne(p => p.Cafedra)
                .WithMany()
                .HasForeignKey(p => p.Cafedra_ID)
                .HasConstraintName("fk_cafedra_id")
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasIndex(p => p.Cafedra_ID, $"idx_{TableName}_fk_cafedra_id");

            builder.Property(p => p.Position_ID)
                .HasColumnName("position_id")
                .HasColumnType(ColumnType.Int);
            builder.HasOne(p=>p.Position)
                .WithMany()
                .HasForeignKey(p => p.Position_ID)
                .HasConstraintName("fk_position_id")
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasIndex(p => p.Position_ID, $"idx_{TableName}_fk_position_id");
            builder.Navigation(p => p.Position)
                .AutoInclude();
            builder.Property(p => p.Degree_ID)
               .HasColumnName("degree_id")
               .HasColumnType(ColumnType.Int);

            builder.HasOne(p => p.Degree)
                .WithMany()
                .HasForeignKey(p => p.Degree_ID)
                .HasConstraintName("fk_degree_id")
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasIndex(
                p => p.Degree_ID, $"idx_{TableName}_fk_degree_id"
            );

            builder.Navigation(p => p.Degree)
                .AutoInclude();
            builder.Property(p => p.Discipline_ID)
              .HasColumnName("discipline_id")
              .HasColumnType(ColumnType.Int);

            builder.HasOne(p => p.Discipline)
                .WithMany()
                .HasForeignKey(p => p.Discipline_ID)
                .HasConstraintName("fk_discipline_id")
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasIndex(
                p => p.Discipline_ID, $"idx_{TableName}_fk_discipline_id"
            );

            builder.Navigation(p => p.Discipline)
                .AutoInclude();

            // Load
            builder.Property(p => p.Load_ID)
                .HasColumnName("load_id")
                .HasColumnType(ColumnType.Int);
            builder.HasOne(p=>p.Load)
                .WithMany()
                .HasForeignKey(p=>p.Load_ID)
                .HasConstraintName("fk_teacher_load_id")
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasIndex(
                p => p.Load_ID, $"idx_{TableName}_fk_load_id"
            );

            builder.Navigation(p => p.Load)
                .AutoInclude();

            builder.ToTable(TableName);
        }
    }
}
