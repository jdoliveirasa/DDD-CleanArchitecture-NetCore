using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VxTel.FaleMais.Application.Interfaces;
using VxTel.FaleMais.Application.ViewModels;

namespace VxTel.FaleMais.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FaleMaisController : ControllerBase
    {
        private readonly ILogger<FaleMaisController> _logger;
        private readonly IAreaCodeService _areaCodeService;
        private readonly IPlanService _planService;
        private readonly IExceedingMinuteService _exceedingMinuteService;

        public FaleMaisController(ILogger<FaleMaisController> logger, IAreaCodeService areaCodeService,
            IPlanService planService, IExceedingMinuteService exceedingMinuteService)
        {
            _logger = logger;
            _areaCodeService = areaCodeService;
            _planService = planService;
            _exceedingMinuteService = exceedingMinuteService;
        }

        [HttpGet]
        [Route("areacodes")]
        public async Task<IEnumerable<AreaCodeViewModel>> GetAreaCodes()
        {
            var areaCodes = await _areaCodeService.GetAreaCodes();
            return areaCodes.ToArray();
        }

        [HttpGet]
        [Route("plans")]
        public async Task<IEnumerable<PlanViewModel>> GetPlans()
        {
            var plans = await _planService.GetPlans();
            return plans.ToArray();
        }

        [HttpPost]
        [Route("search")]
        public async Task<IEnumerable<ExceedingMinuteViewModel>> Search(int OriginId, int DestinyId,
            int TimeInMinutes, int PlanId)
        {
            var exceedingMinutes = await _exceedingMinuteService.SearchPricesFaleMais(OriginId, DestinyId,
                TimeInMinutes, PlanId);
            return exceedingMinutes.ToList();
        }
    }
}
