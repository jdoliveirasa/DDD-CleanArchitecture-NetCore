using System.Collections.Generic;
using System.Threading.Tasks;
using VxTel.FaleMais.Application.ViewModels;

namespace VxTel.FaleMais.Application.Interfaces
{
    public interface IPlanService
    {
        Task<IEnumerable<PlanViewModel>> GetPlans();

        Task<PlanViewModel> GetById(int? id);
    }
}
