using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using VxTel.FaleMais.Application.Interfaces;
using VxTel.FaleMais.Application.ViewModels;
using VxTel.FaleMais.Domain.Interface;

namespace VxTel.FaleMais.Application.Services
{
    public class AreaCodeService : IAreaCodeService
    {
        private IAreaCodeRepository _areaCodeRepository;
        private readonly IMapper _mapper;

        public AreaCodeService(IMapper mapper, IAreaCodeRepository areaCodeRepository)
        {
            _mapper = mapper;
            _areaCodeRepository = areaCodeRepository;
        }

        public async Task<AreaCodeViewModel> GetById(int? id)
        {
            var result = await _areaCodeRepository.GetById(id);
            return _mapper.Map<AreaCodeViewModel>(result);
        }

        public async Task<IEnumerable<AreaCodeViewModel>> GetAreaCodes()
        {
            var result = await _areaCodeRepository.GetAreaCodes();
            return _mapper.Map<IEnumerable<AreaCodeViewModel>>(result);
        }
    }
}
