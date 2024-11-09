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
            builder.Property(p => p.Discipline_Load_Id)
                .HasColumnName("discipline_load_id")
                .HasColumnType(ColumnType.Int);
            builder.HasOne(p => p.Discipline_Load_Hours)
                .WithOne()
                .HasForeignKey<Discipline>(p => p.Discipline_Load_Id)
                .HasConstraintName("fk_load_id")
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasIndex(p => p.Discipline_Load_Id, $"idx_{TableName}_fk_load_id");
            builder.ToTable(TableName);
        }
    }
}
