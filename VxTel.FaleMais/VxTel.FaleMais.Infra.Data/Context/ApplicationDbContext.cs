using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VxTel.FaleMais.Domain.Entities;
using VxTel.FaleMais.Infra.Data.EntityConfigurations;

namespace VxTel.FaleMais.Infra.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AreaCode> AreaCodes { get; set; }
        public DbSet<ExceedingMinute> ExceedingMinutes { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Rate> Rates { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AreaCodeConfiguration());
            builder.ApplyConfiguration(new ExceedingMinuteConfiguration());
            builder.ApplyConfiguration(new PlanConfiguration());
            builder.ApplyConfiguration(new RateConfiguration());
        }
    }
}