using Proekt_Prakt_Lab.Models;
using Proekt_Prakt_Lab.Database.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Proekt_Prakt_Lab.Database.Configurations
{
    public class CafedraConfiguration : IEntityTypeConfiguration<Cafedra>
    {
        private const string TableName = "cd_cafedra";
        public void Configure(EntityTypeBuilder<Cafedra> builder) {
            builder
                    .HasKey(p => p.Cafedra_ID)
                    .HasName($"pk_{TableName}_cafedra_id");
            builder.Property(p => p.Cafedra_ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("cafedra_id");
            builder.Property(p => p.Cafedra_Name)
                .HasColumnName("c_cafedra_name")
                .HasColumnType(ColumnType.String)
                .HasMaxLength(100);
            builder.Property(p => p.Main_Teacher_ID)
                .HasColumnName("main_teacher_id")
                .HasColumnType(ColumnType.Int);
            builder.HasOne(p=>p.Main_teacher)
                .WithOne()
                .HasForeignKey<Cafedra>(p=>p.Main_Teacher_ID)
                .HasConstraintName("fk_main_teacher_id")
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasIndex(p=>p.Main_Teacher_ID,$"idx_{TableName}_fk_main_teacher_id");
            builder.ToTable(TableName);

        }

    }

}

