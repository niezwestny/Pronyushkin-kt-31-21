using Proekt_Prakt_Lab.Models;
using Proekt_Prakt_Lab.Database.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Proekt_Prakt_Lab.Database.Configurations
{
    public class LoadConfiguration:IEntityTypeConfiguration<Load>
    {
        private const string TableName = "cd_load";
        public void Configure(EntityTypeBuilder<Load> builder)
        {

            builder
                .HasKey(p => p.Load_ID)
                .HasName($"pk_{TableName}_load_id");
            builder.Property(p => p.Load_ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("load_id");
            builder.Property(p => p.Hours)
                .HasColumnName("c_hours")
                .HasColumnType(ColumnType.Int);


            builder.ToTable(TableName);
        }
    }
}
