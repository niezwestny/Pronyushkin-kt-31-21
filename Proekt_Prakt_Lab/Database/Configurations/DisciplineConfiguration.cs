using Proekt_Prakt_Lab.Models;
using Proekt_Prakt_Lab.Database.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Proekt_Prakt_Lab.Database.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    { 
        private const string TableName = "cd_discipline";
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder
                .HasKey(p => p.Discipline_ID)
                .HasName($"pk_{TableName}_discipline_id");
            builder.Property(p => p.Discipline_ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("discipline_id");
            builder.Property(p => p.Discipline_Name)
                .HasColumnName("c_discipline_name")
                .HasColumnType(ColumnType.String)
                .HasMaxLength(100);
            builder.Property(p => p.Discipline_Load_Hours)
                .HasColumnName("discipline_load_hours")
                .HasColumnType(ColumnType.Int);
            builder.Property(p => p.Discipline_Teacher_ID)
                .HasColumnName("c_discipline_teacher_id")
                .HasColumnType(ColumnType.Int);
            builder.HasOne(p=> p.Discipline_Teacher_FIO)
                .WithOne()
                .HasForeignKey<Discipline>(p=>p.Discipline_Teacher_ID)
                .HasConstraintName("fk_discipline_teacher_id")
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasIndex(p => p.Discipline_Teacher_ID, $"idx_{TableName}_fk_discipline_teacher_id");
            builder.ToTable(TableName);
        }
    }
}
