using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<bool> AddPosition(PositionVM positionVM)
        {
            bool result;

            Position position = Conversion.ConvertToPosition(positionVM);

            await context.Positions.AddAsync(position);
            result = await context.SaveChangesAsync() > 0;

            if (result) AddTestsToPosition(position.IdPosition, positionVM.TestsId);

            return result;
        }

        public async Task<bool> UpdatePosition(PositionUpdateVM positionUpdateVM)
        {
            bool result;

            Position position = await context.Positions.AsNoTracking().FirstOrDefaultAsync(u => u.IdPosition == positionUpdateVM.IdPosition);

            position = Conversion.ConvertToPosition(position, positionUpdateVM);

            context.Positions.Update(position);
            result = await context.SaveChangesAsync() > 0;

            if (result) AddTestsToPosition(position.IdPosition, positionUpdateVM.TestsId, true);

            return result;
        }

        public async Task<bool> DeletePosition(int postitionId)
        {
            var result = false;

            Position position = await context.Positions.FirstOrDefaultAsync(p => p.IdPosition == postitionId);

            if (position != null)
            {
                context.Positions.Remove(position);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        public async Task<List<PositionDTO>> GetAllPositions()
        {
            List<Position> positions = await context.Positions.ToListAsync();

            List<PositionDTO> positionDTOs = new List<PositionDTO>();

            if (positions != null)
            {
                foreach (Position position in positions)
                {
                    positionDTOs.Add(Conversion.ConvertToPositionDTO(position));
                }
            }

            return positionDTOs;
        }

        public async Task<PositionUpdateVM> GetPositionUpdate(int id)
        {
            Position position = await context.Positions.Include(p => p.Tests).FirstOrDefaultAsync(s => s.IdPosition == id);

            List<int> testsId = new List<int>();

            if (position != null)
            {
                foreach (Test_Position positionId in position.Tests)
                {
                    testsId.Add(positionId.IdTest);
                }
            }

            PositionUpdateVM positionUpdateVM = Conversion.ConvertToPositionUpdateVM(position, testsId);

            return positionUpdateVM;
        }

        public async Task<List<Test>> GetAllTests()
        {
            return await context.Tests.ToListAsync();
        }

        private void AddTestsToPosition(int positionId, List<int> testsId, bool delete = false)
        {
            if (delete)
            {
                List<Test_Position> testPositions = context.Test_Positions.Where(tp => tp.IdPosition == positionId).ToList();

                if (testPositions != null)
                {
                    context.Test_Positions.RemoveRange(testPositions);
                    context.SaveChanges();
                }
            }

            if (testsId != null)
            {
                foreach (int id in testsId)
                {
                    context.Test_Positions.Add(new Test_Position
                    {
                        IdTest = id,
                        IdPosition = positionId
                    });
                }
                
                context.SaveChanges();
            }
        }
    }
}
