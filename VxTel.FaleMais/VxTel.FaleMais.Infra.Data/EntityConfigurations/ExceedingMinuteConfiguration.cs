using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VxTel.FaleMais.Domain.Entities;

namespace VxTel.FaleMais.Infra.Data.EntityConfigurations
{
    public class ExceedingMinuteConfiguration : IEntityTypeConfiguration<ExceedingMinute>
    {
        public void Configure(EntityTypeBuilder<ExceedingMinute> builder)
        {
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();
            builder.HasOne(p => p.Origin)
                .WithMany(t => t.OriginAreaCodes)
                .HasForeignKey(m => m.OriginId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Destiny)
                .WithMany(t => t.DestinyAreaCodes)
                .HasForeignKey(m => m.DestinyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new ExceedingMinute
                {
                    Id = 1,
                    Description = "VXFLMEXCMIN011016",
                    OriginId = 1,
                    DestinyId = 2,
                    MinutePriceId = 1
                },
                new ExceedingMinute
                {
                    Id = 2,
                    Description = "VXFLMEXCMIN016011",
                    OriginId = 2,
                    DestinyId = 1,
                    MinutePriceId = 2
                },
                new ExceedingMinute
                {
                    Id = 3,
                    Description = "VXFLMEXCMIN011017",
                    OriginId = 1,
                    DestinyId = 3,
                    MinutePriceId = 3
                },
                new ExceedingMinute
                {
                    Id = 4,
                    Description = "VXFLMEXCMIN017011",
                    OriginId = 3,
                    DestinyId = 1,
                    MinutePriceId = 4
                },

                new ExceedingMinute
                {
                    Id = 5,
                    Description = "VXFLMEXCMIN011018",
                    OriginId = 1,
                    DestinyId = 4,
                    MinutePriceId = 5
                },
                 new ExceedingMinute
                 {
                     Id = 6,
                     Description = "VXFLMEXCMIN018011",
                     OriginId = 4,
                     DestinyId = 1,
                     MinutePriceId = 1
                 }
                );
        }
    }
}
