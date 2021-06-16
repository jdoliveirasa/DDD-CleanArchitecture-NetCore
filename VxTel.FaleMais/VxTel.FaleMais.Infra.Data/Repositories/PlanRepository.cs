using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VxTel.FaleMais.Domain.Entities;
using VxTel.FaleMais.Domain.Interface;
using VxTel.FaleMais.Infra.Data.Context;

namespace VxTel.FaleMais.Infra.Data.Repositories
{
    public class PlanRepository : IPlanRepository
    {
        private ApplicationDbContext _context;
        public PlanRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Plan>> GetPlans()
        {
            return await _context.Plans.ToListAsync();
        }

        public async Task<Plan> GetById(int? id)
        {
            return await _context.Plans.FindAsync(id);
        }
    }
}