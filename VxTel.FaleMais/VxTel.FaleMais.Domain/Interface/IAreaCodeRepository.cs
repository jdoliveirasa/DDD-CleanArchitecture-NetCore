using System.Collections.Generic;
using System.Threading.Tasks;
using VxTel.FaleMais.Domain.Entities;

namespace VxTel.FaleMais.Domain.Interface
{
    public interface IAreaCodeRepository
    {
        Task<IEnumerable<AreaCode>> GetAreaCodes();

        Task<AreaCode> GetById(int? id);
    }
}
