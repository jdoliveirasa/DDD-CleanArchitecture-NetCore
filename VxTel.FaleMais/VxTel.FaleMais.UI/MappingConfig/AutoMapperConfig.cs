using Microsoft.Extensions.DependencyInjection;
using System;
using VxTel.FaleMais.Application.Mappings;

namespace VxTel.FaleMais.UI.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfigurarion(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile),
                typeof(ViewModelToDomainMappingProfile));
        }
    }
}