using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VxTel.FaleMais.Application.Interfaces;
using VxTel.FaleMais.Application.ViewModels;
using VxTel.FaleMais.Domain.Entities;
using VxTel.FaleMais.Domain.Interface;

namespace VxTel.FaleMais.Application.Services
{
    public class ExceedingMinuteService : IExceedingMinuteService
    {
        private IExceedingMinuteRepository _exceedingMinuteRepository;
        private IPlanRepository _planRepository;
        private IAreaCodeRepository _areaCodeRepository;

        private readonly IMapper _mapper;

        public ExceedingMinuteService(IMapper mapper, IExceedingMinuteRepository exceedingMinuteRepository,
            IPlanRepository planRepository, IAreaCodeRepository areaCodeRepository)
        {
            _mapper = mapper;
            _exceedingMinuteRepository = exceedingMinuteRepository;
            _planRepository = planRepository;
            _areaCodeRepository = areaCodeRepository;
        }

        public async Task<IEnumerable<ExceedingMinuteViewModel>> SearchPricesFaleMais(int OriginId, int DestinyId, int TimeInMinutes, int PlanId)
        {
            var plan = await _planRepository.GetById(PlanId);
            var result = await _exceedingMinuteRepository.SearchPricesFaleMais(OriginId, DestinyId, TimeInMinutes, PlanId);
            var resultList = result.ToList();
            if (resultList.Count > 0)
            {
                foreach (ExceedingMinute item in resultList)
                {
                    item.CalculateValueCall(TimeInMinutes, plan);
                }
            }
            else
            {
                var exceedingMinute = new ExceedingMinute
                {
                    Destiny = await _areaCodeRepository.GetById(OriginId),
                    Origin = await _areaCodeRepository.GetById(DestinyId),
                    TimeInMinutes = TimeInMinutes,
                    PlanDescription = plan.Description,
                    AmountPayableWithPlan = -1,
                    AmountPayable = -1
                };
                var list = new List<ExceedingMinute>();
                list.Add(exceedingMinute);
                result = list;
            }
            return _mapper.Map<IEnumerable<ExceedingMinuteViewModel>>(result);
        }
    }
}
