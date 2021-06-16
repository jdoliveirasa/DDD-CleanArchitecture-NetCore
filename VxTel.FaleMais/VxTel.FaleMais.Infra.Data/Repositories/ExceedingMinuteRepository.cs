using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VxTel.FaleMais.Domain.Entities;
using VxTel.FaleMais.Domain.Interface;
using VxTel.FaleMais.Infra.Data.Context;

namespace VxTel.FaleMais.Infra.Data.Repositories
{
    public class ExceedingMinuteRepository : IExceedingMinuteRepository
    {
        private ApplicationDbContext _context;
        public ExceedingMinuteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ExceedingMinute>> SearchPricesFaleMais(int OriginId, int DestinyId, int TimeInMinutes, int PlanId)
        {
            return await _context.ExceedingMinutes
                .Include(p => p.Origin)
                .Include(p => p.Destiny)
                .Include(p => p.MinutePrice)
                .Where(p => p.OriginId == OriginId &&
                    p.DestinyId == DestinyId).ToListAsync();
        }
    }
}