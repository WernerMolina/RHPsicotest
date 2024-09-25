using Microsoft.AspNetCore.Http;
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
using System.Security.Claims;
using System.Threading.Tasks;


namespace RHPsicotest.WebSite.Repositories
{
    public class ExpedientRepository : IExpedientRepository
    {
        private readonly RHPsicotestDbContext context;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ExpedientRepository(RHPsicotestDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> AddExpedient(ExpedientVM expedientVM)
        {
            if (Helper.CalculateAge(expedientVM.DateOfBirth) < 15)
                throw new Exception("Tiene que ser mayor de 14 años");

            string userNameFull = $"{expedientVM.Names}{expedientVM.Lastnames}".Replace(" ", "");
            string fileName = await FileServices.SaveCurriculum(expedientVM.CurriculumVitae, userNameFull);

            (string, string, string) currentCandidate = GetClaims();

            Expedient expedient = Conversion.ConvertToExpedient(expedientVM, currentCandidate, fileName);

            await context.Expedients.AddAsync(expedient);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateExpedient(ExpedientUpdateVM expedienUpdatetVM)
        {
            bool result = false;

            Expedient expedient = await context.Expedients.AsNoTracking().FirstOrDefaultAsync(e => e.IdExpedient == expedienUpdatetVM.IdExpedient);

            if (expedient != null)
            {
                expedient = Conversion.ConvertToExpedient(expedient, expedienUpdatetVM);

                context.Expedients.Update(expedient);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        public async Task<List<ExpedientDTO>> GetAllExpedients()
        {
            List<Expedient> expedients = await context.Expedients.OrderByDescending(e => e.IdExpedient).ToListAsync();

            List<ExpedientDTO> expedientDTOs = new List<ExpedientDTO>();

            if (expedients != null)
            {
                foreach (Expedient expedient in expedients)
                {
                    expedientDTOs.Add(Conversion.ConvertToExpedientDTO(expedient));
                }
            }

            return expedientDTOs;
        }

        public async Task<Expedient> GetExpedient(int expedientId)
        {
            return await context.Expedients.FirstOrDefaultAsync(e => e.IdExpedient == expedientId);
        }

        public async Task<ExpedientUpdateVM> GetExpedientUpdateVM(int expedientId)
        {
            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdExpedient == expedientId);

            ExpedientUpdateVM expedientUpdateVM = new ExpedientUpdateVM();

            if (expedient != null)
            {
                expedientUpdateVM = Conversion.ConvertToExpedientUpdateVM(expedient);
            }

            return expedientUpdateVM;
        }

        public async Task<byte[]> GetPDFInBytes(int id)
        {
            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdExpedient == id);

            return FileServices.GetCurriculum(expedient.FileName);
        }

        public async Task<bool> HasExpedient(int candidateId)
        {
            Candidate candidate = await context.Candidates.Include(t => t.Expedient).FirstOrDefaultAsync(e => e.IdCandidate == candidateId);

            if (candidate.Expedient != null) return true;

            return false;
        }

        public async Task<List<ResultDTO>> GetResults(int expedientId)
        {
            List<Result> results = await context.Results.Where(e => e.IdExpedient == expedientId).ToListAsync();

            List<ResultDTO> resultDTOs = new List<ResultDTO>();

            for (int i = 1; i <= 7; i++)
            {
                List<Result> results2 = results.Where(r => r.IdTest == i).ToList();

                if (results2.Count != 0) resultDTOs.Add(Conversion.ConvertToResultDTO(i, results2));
            }

            return resultDTOs;
        }


        private (string, string, string) GetClaims()
        {
            ClaimsPrincipal claimsPrincipal = httpContextAccessor.HttpContext.User;

            return (claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier).Value,
                claimsPrincipal.FindFirst(ClaimTypes.Email).Value,
                claimsPrincipal.FindFirst("Position").Value);
        }
    }
}
