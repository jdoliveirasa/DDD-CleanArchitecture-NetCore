using AutoMapper;
using VxTel.FaleMais.Application.ViewModels;
using VxTel.FaleMais.Domain.Entities;

namespace VxTel.FaleMais.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<AreaCode, AreaCodeViewModel>();
            CreateMap<Plan, PlanViewModel>();
            CreateMap<ExceedingMinute, ExceedingMinuteViewModel>();
        }
    }
}
