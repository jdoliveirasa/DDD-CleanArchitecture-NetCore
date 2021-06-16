using System.Collections.Generic;
using System.Threading.Tasks;
using VxTel.FaleMais.Domain.Entities;

namespace VxTel.FaleMais.Domain.Interface
{
    public interface IPlanRepository
    {
        Task<IEnumerable<Plan>> GetPlans();

        Task<Plan> GetById(int? id);
    }
}
