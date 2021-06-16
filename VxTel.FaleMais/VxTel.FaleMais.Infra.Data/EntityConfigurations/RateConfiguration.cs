using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VxTel.FaleMais.Domain.Entities;

namespace VxTel.FaleMais.Infra.Data.EntityConfigurations
{
    public class RateConfiguration : IEntityTypeConfiguration<Rate>
    {
        public void Configure(EntityTypeBuilder<Rate> builder)
        {
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Price).HasPrecision(10, 2);

            builder.HasData(
                new Rate
                {
                    Id = 1,
                    Description = "VXFLM190",
                    Price = 1.90M
                },
                new Rate
                {
                    Id = 2,
                    Description = "VXFLM290",
                    Price = 2.90M
                },
                new Rate
                {
                    Id = 3,
                    Description = "VXFLM170",
                    Price = 1.70M
                },
                new Rate
                {
                    Id = 4,
                    Description = "VXFLM270",
                    Price = 2.70M
                },
                new Rate
                {
                    Id = 5,
                    Description = "VXFLM090",
                    Price = 0.90M
                }                
                );
        }
    }
}
