using Proekt_Prakt_Lab.Models;
using Proekt_Prakt_Lab.Database.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Proekt_Prakt_Lab.Database.Configurations
{
    public class PositionConfiguration:IEntityTypeConfiguration<Position>   
    {
        private const string TableName = "cd_position";
        public void Configure(EntityTypeBuilder<Position> builder) {
            builder
        .HasKey(p => p.Position_ID)
        .HasName($"pk_{TableName}_position_id");

            builder.Property(p => p.Position_ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("position_id");

            builder.Property(p => p.Position_Name)
                .HasColumnName("c_position_name")
                .HasColumnType(ColumnType.String)
                .HasMaxLength(100);

            builder.ToTable(TableName);
        }
    }
}
