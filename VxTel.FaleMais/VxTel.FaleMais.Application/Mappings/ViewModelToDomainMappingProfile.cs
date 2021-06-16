using AutoMapper;
using VxTel.FaleMais.Application.ViewModels;
using VxTel.FaleMais.Domain.Entities;

namespace VxTel.FaleMais.Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AreaCodeViewModel, AreaCode>();
            CreateMap<PlanViewModel, Plan>();
            CreateMap<ExceedingMinuteViewModel, ExceedingMinute>();
        }
    }
}
