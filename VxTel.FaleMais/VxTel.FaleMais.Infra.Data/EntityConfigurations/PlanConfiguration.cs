using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VxTel.FaleMais.Domain.Entities;

namespace VxTel.FaleMais.Infra.Data.EntityConfigurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Minutes);

            builder.HasData(
                new Plan
                {
                    Id = 1,
                    Description = "FaleMais 30 (30 minutos)",
                    Minutes = 30
                },
                new Plan
                {
                    Id = 2,
                    Description = "FaleMais 60 (60 minutos)",
                    Minutes = 60
                },
                 new Plan
                 {
                     Id = 3,
                     Description = "FaleMais 120 (120 minutos)",
                     Minutes = 120
                 }
                );
        }
    }
}
