using Proekt_Prakt_Lab.Models;
using Proekt_Prakt_Lab.Database.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Proekt_Prakt_Lab.Database.Configurations
{
    public class DegreeConfiguration : IEntityTypeConfiguration<Degree>

    {
        private const string TableName = "cd_degree";
        public void Configure(EntityTypeBuilder<Degree> builder) {
            builder
                    .HasKey(p => p.Degree_ID)
                    .HasName($"pk_{TableName}_degree_id");
            builder.Property(p => p.Degree_ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("degree_id");
            builder.Property(p => p.Degree_Name)
                .HasColumnName("c_degree_name")
                .HasColumnType(ColumnType.String)
                .HasMaxLength(100);
            builder.ToTable(TableName);
        }
    }
}
