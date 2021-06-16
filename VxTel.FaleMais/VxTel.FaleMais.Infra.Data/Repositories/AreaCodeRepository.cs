using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VxTel.FaleMais.Domain.Entities;
using VxTel.FaleMais.Domain.Interface;
using VxTel.FaleMais.Infra.Data.Context;

namespace VxTel.FaleMais.Infra.Data.Repositories
{
    public class AreaCodeRepository : IAreaCodeRepository
    {
        private ApplicationDbContext _context;
        public AreaCodeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AreaCode>> GetAreaCodes()
        {
            return await _context.AreaCodes.ToListAsync();
        }

        public async Task<AreaCode> GetById(int? id)
        {
            return await _context.AreaCodes.FindAsync(id);
        }
    }
}
