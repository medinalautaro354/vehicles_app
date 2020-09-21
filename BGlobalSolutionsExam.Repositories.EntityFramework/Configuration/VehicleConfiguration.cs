using BGlobalSolutionsExam.Repositories.EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BGlobalSolutionsExam.Repositories.EntityFramework.Configuration
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicle");

            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.HasKey(f => f.Id);

            builder.Property(f => f.LicensePlate).HasMaxLength(8).IsRequired();
            builder.Property(f => f.NumberOfDoors).IsRequired();
            builder.Property(f => f.Owner).IsRequired();
            builder.Property(f => f.Brand).IsRequired();
            builder.Property(f => f.IsActive).HasDefaultValue(true);
        }
    }
}
