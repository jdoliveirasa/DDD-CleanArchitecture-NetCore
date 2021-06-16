using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VxTel.FaleMais.Domain.Entities;

namespace VxTel.FaleMais.Infra.Data.EntityConfigurations
{
    public class AreaCodeConfiguration : IEntityTypeConfiguration<AreaCode>
    {
        public void Configure(EntityTypeBuilder<AreaCode> builder)
        {
            builder.Property(p => p.Code).HasMaxLength(3).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();

            builder.HasData(
                new AreaCode
                {
                    Id = 1,
                    Code = "011",
                    Description = "Código da Área 11"
                },
                new AreaCode
                {
                    Id = 2,
                    Code = "016",
                    Description = "Código da Área 16"
                },
                new AreaCode
                {
                    Id = 3,
                    Code = "017",
                    Description = "Código da Área 17"
                },
                new AreaCode
                {
                    Id = 4,
                    Code = "018",
                    Description = "Código da Área 18"
                }
                );
        }
    }
}