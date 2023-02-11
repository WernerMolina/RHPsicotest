using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IPositionRepository
    {
        public Task<IEnumerable<Position>> GetAllPositions();

        public Task<Position> GetPosition(int id);

        public Task<Position> AddPosition(Position position);

        public Task<bool> UpdatePosition(Position position);

        public Task<bool> DeletePosition(int id);
    }
}
