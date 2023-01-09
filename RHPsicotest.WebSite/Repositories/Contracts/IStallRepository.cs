using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IStallRepository
    {
        public Task<IEnumerable<Stall>> GetAllStalls();

        public Task<Stall> GetStall(int id);

        public Task<Stall> AddStall(Stall stall);

        public Task<bool> UpdateStall(Stall stall);

        public Task<bool> DeleteStall(int id);
    }
}
