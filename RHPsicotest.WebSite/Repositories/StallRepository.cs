using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories
{
    public class StallRepository : IStallRepository
    {
        private readonly RHPsicotestDbContext context;

        public StallRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        public async Task<Stall> AddStall(Stall stall)
        {
            bool stallExists = await StallExists(stall);

            if (!stallExists)
            {
                var result = await context.Stalls.AddAsync(stall);
                await context.SaveChangesAsync();

                return result.Entity;
            }

            return null;
        }

        public async Task<bool> DeleteStall(int id)
        {
            var result = false;
            Stall stall = await GetStall(id);

            if (stall != null)
            {
                context.Stalls.Remove(stall);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        public async Task<IEnumerable<Stall>> GetAllStalls()
        {
            return await context.Stalls.ToListAsync();
        }

        public async Task<Stall> GetStall(int id)
        {
            return await context.Stalls.AsNoTracking().FirstOrDefaultAsync(s => s.IdStall == id);
        }

        public async Task<bool> UpdateStall(Stall stall)
        {
            var _stall = await GetStall(stall.IdStall);

            var result = false;

            if (_stall != null)
            {
                stall.CreationDate = _stall.CreationDate;

                context.Stalls.Update(stall);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        private async Task<bool> StallExists(Stall stall)
        {
            return await context.Stalls.AnyAsync(s => s.StallName== stall.StallName);
        }
    }
}
