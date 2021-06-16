using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VxTel.FaleMais.Application.Interfaces;
using VxTel.FaleMais.Infra.Data.Models;

namespace VxTel.FaleMais.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAreaCodeService _areaCodeService;
        private readonly IPlanService _planService;
        private readonly IExceedingMinuteService _exceedingMinuteService;

        public HomeController(ILogger<HomeController> logger, IAreaCodeService areaCodeService,
            IPlanService planService, IExceedingMinuteService exceedingMinuteService)
        {
            _logger = logger;
            _areaCodeService = areaCodeService;
            _planService = planService;
            _exceedingMinuteService = exceedingMinuteService;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var resultAreaCodeOrigin = await _areaCodeService.GetAreaCodes();
            var resultAareaCodeDestiny = await _areaCodeService.GetAreaCodes();
            var resultPlan = await _planService.GetPlans();

            ViewBag.AreaCodeOrigin = resultAreaCodeOrigin.Select(c => new SelectListItem()
            { Text = c.Description, Value = c.Id.ToString() }).ToList();

            ViewBag.AreaCodeDestiny = resultAareaCodeDestiny.Select(c => new SelectListItem()
            { Text = c.Description, Value = c.Id.ToString() }).ToList();

            ViewBag.Plan = resultPlan.Select(c => new SelectListItem()
            { Text = c.Description, Value = c.Id.ToString() }).ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Search(int OriginId, int DestinyId, int TimeInMinutes, int PlanId)
        {
            var resultExceedingMinute = await _exceedingMinuteService.SearchPricesFaleMais(OriginId, DestinyId, TimeInMinutes, PlanId);
            return View(resultExceedingMinute);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}