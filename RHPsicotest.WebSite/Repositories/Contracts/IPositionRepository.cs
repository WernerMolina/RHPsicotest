using Microsoft.AspNetCore.Mvc.Rendering;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IPositionRepository
    {
        public Task<bool> AddPosition(PositionVM positionVM);

        public Task<bool> UpdatePosition(PositionUpdateVM positionUpdateVM);

        public Task<bool> DeletePosition(int id);

        public Task<List<PositionDTO>> GetAllPositions();

        public Task<PositionUpdateVM> GetPositionUpdate(int positionId);

        public Task<List<Test>> GetAllTests();
    }
}
