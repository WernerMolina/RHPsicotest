using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using RHPsicotest.WebSite.ViewModels.User;
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

        public async Task<bool> AddPosition(PositionVM positionVM, List<int> testsId)
        {
            bool result = false;

            bool positionExists = await PositionExists(positionVM.PositionName);

            if (!positionExists)
            {
                Position position = Conversion.ConvertToPosition(positionVM);

                var entity = await context.Positions.AddAsync(position);
                result = await context.SaveChangesAsync() > 0;

                AssignTests(Convert.ToInt32(entity.Entity.IdPosition), testsId);
            }

            return result;
        }

        public async Task<bool> UpdatePosition(PositionUpdateVM positionUpdateVM, List<int> testsId)
        {
            bool result = false;

            Position position = await context.Positions.AsNoTracking().FirstOrDefaultAsync(u => u.PositionName == positionUpdateVM.PositionName);

            if (position == null || position.IdPosition == positionUpdateVM.IdPosition)
            {
                if (position == null)
                {
                    position = await context.Positions.AsNoTracking().FirstOrDefaultAsync(u => u.IdPosition == positionUpdateVM.IdPosition);
                }

                position = Conversion.ConvertToPosition(position, positionUpdateVM);

                var entity = context.Positions.Update(position);
                result = await context.SaveChangesAsync() > 0;

                AssignTests(Convert.ToInt32(entity.Entity.IdPosition), testsId, true);
            }

            return result;
        }

        public async Task<bool> DeletePosition(int id)
        {
            var result = false;
            Position position = await context.Positions.FirstOrDefaultAsync(p => p.IdPosition == id);

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
            Position position = await context.Positions.FirstOrDefaultAsync(s => s.IdPosition == id);

            PositionUpdateVM positionUpdateVM = Conversion.ConvertToPositionUpdateVM(position);

            return positionUpdateVM;
        }
        
        public async Task<MultiSelectList> GetAllTests()
        {
            List<Test> tests = await context.Tests.ToListAsync();

            return new MultiSelectList(tests, "IdTest", "NameTest");
        }



        private async Task<bool> PositionExists(string positionName)
        {
            return await context.Positions.AnyAsync(s => s.PositionName == positionName);
        }

        public async Task<(PositionUpdateVM, MultiSelectList)> GetPositionAndTestsSelected(int positionId)
        {
            Position position = await context.Positions.Include(p => p.Tests).FirstOrDefaultAsync(p => p.IdPosition == positionId);

            PositionUpdateVM positionUpdateVM = Conversion.ConvertToPositionUpdateVM(position);

            MultiSelectList testsList = await GetTestsSelected(position);

            return (positionUpdateVM, testsList);
        }

        public async Task<MultiSelectList> GetTestsSelected(List<int> testsId)
        {
            List<int> selectedTests = new List<int>();
            List<Test> tests = await context.Tests.ToListAsync();

            foreach (int test in testsId)
            {
                selectedTests.Add(test);
            }

            return new MultiSelectList(tests, "IdTest", "NameTest", selectedTests);
        }


        // ----------------------------------
        private async Task<MultiSelectList> GetTestsSelected(Position position)
        {
            List<int> selectedTests = new List<int>();
            List<Test> tests = await context.Tests.ToListAsync();

            foreach (var test in position.Tests)
            {
                selectedTests.Add(test.IdTest);
            }

            return new MultiSelectList(tests, "IdTest", "NameTest", selectedTests);
        }

        private void AssignTests(int positionId, List<int> testsId, bool delete = false)
        {
            // Aquí se eliminan las pruebas actuales del usuario
            if (delete)
            {
                List<Test_Position> testPositions = context.Test_Positions.Where(tp => tp.IdPosition == positionId).ToList();

                if (testPositions != null)
                {
                    context.Test_Positions.RemoveRange(testPositions);
                    context.SaveChanges();
                }
            }

            // Aquí se guardan las nuevas pruebas asignadas
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
