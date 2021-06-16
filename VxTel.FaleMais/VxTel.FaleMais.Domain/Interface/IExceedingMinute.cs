using System.Collections.Generic;
using System.Threading.Tasks;
using VxTel.FaleMais.Domain.Entities;

namespace VxTel.FaleMais.Domain.Interface
{
    public interface IExceedingMinuteRepository
    {
        Task<IEnumerable<ExceedingMinute>> SearchPricesFaleMais(int OriginId, int DestinyId, int TimeInMinutes, int PlanId);
    }
}
