using System.Collections.Generic;
using System.Threading.Tasks;
using VxTel.FaleMais.Application.ViewModels;

namespace VxTel.FaleMais.Application.Interfaces
{
    public interface IAreaCodeService
    {
        Task<IEnumerable<AreaCodeViewModel>> GetAreaCodes();
        
        Task<AreaCodeViewModel> GetById(int? id);
    }
}
