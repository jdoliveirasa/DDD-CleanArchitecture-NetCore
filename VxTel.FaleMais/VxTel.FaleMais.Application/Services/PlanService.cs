using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using VxTel.FaleMais.Application.Interfaces;
using VxTel.FaleMais.Application.ViewModels;
using VxTel.FaleMais.Domain.Interface;

namespace VxTel.FaleMais.Application.Services
{
    public class PlanService : IPlanService
    {
        private IPlanRepository _planRepository;
        private readonly IMapper _mapper;

        public PlanService(IMapper mapper, IPlanRepository planRepository)
        {
            _mapper = mapper;
            _planRepository = planRepository;
        }

        public async Task<PlanViewModel> GetById(int? id)
        {
            var result = await _planRepository.GetById(id);
            return _mapper.Map<PlanViewModel>(result);
        }

        public async Task<IEnumerable<PlanViewModel>> GetPlans()
        {
            var result = await _planRepository.GetPlans();
            return _mapper.Map<IEnumerable<PlanViewModel>>(result);
        }
    }
}
