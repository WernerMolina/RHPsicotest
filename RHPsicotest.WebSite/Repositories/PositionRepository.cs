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
    public class PositionRepository : IPositionRepository
    {
        private readonly RHPsicotestDbContext context;

        public PositionRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        public async Task<Position> AddPosition(Position position)
        {
            bool positionExists = await PositionExists(position);

            if (!positionExists)
            {
                var result = await context.Positions.AddAsync(position);
                await context.SaveChangesAsync();

                return result.Entity;
            }

            return null;
        }

        public async Task<bool> DeletePosition(int id)
        {
            var result = false;
            Position position = await GetPosition(id);

            if (position != null)
            {
                context.Positions.Remove(position);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        public async Task<IEnumerable<Position>> GetAllPositions()
        {
            return await context.Positions.ToListAsync();
        }

        public async Task<Position> GetPosition(int id)
        {
            return await context.Positions.AsNoTracking().FirstOrDefaultAsync(s => s.IdPosition == id);
        }

        public async Task<bool> UpdatePosition(Position position)
        {
            var _position = await GetPosition(position.IdPosition);

            var result = false;

            if (_position != null)
            {
                position.CreationDate = _position.CreationDate;

                context.Positions.Update(position);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        private async Task<bool> PositionExists(Position position)
        {
            return await context.Positions.AnyAsync(s => s.PositionName== position.PositionName);
        }
    }
}
