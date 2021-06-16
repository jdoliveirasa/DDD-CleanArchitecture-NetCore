using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VxTel.FaleMais.Application.Interfaces;
using VxTel.FaleMais.Application.Services;
using VxTel.FaleMais.Domain.Interface;
using VxTel.FaleMais.Infra.Data.Context;
using VxTel.FaleMais.Infra.Data.Repositories;

namespace VxTel.FaleMais.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastrucure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext)
                    .Assembly.FullName)));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options =>
            options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IAreaCodeRepository, AreaCodeRepository>();
            services.AddScoped<IAreaCodeService, AreaCodeService>();
            services.AddScoped<IPlanRepository, PlanRepository>();
            services.AddScoped<IPlanService, PlanService>();
            services.AddScoped<IExceedingMinuteRepository, ExceedingMinuteRepository>();
            services.AddScoped<IExceedingMinuteService, ExceedingMinuteService>();

            return services;
        }
    }
}