using System.Collections.Generic;
using System.Threading.Tasks;
using VxTel.FaleMais.Application.ViewModels;

namespace VxTel.FaleMais.Application.Interfaces
{
    public interface IExceedingMinuteService
    {
        Task<IEnumerable<ExceedingMinuteViewModel>> SearchPricesFaleMais(int OriginId, int DestinyId, int TimeInMinutes, int PlanId);
    }
}
