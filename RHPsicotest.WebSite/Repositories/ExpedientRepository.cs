using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.GenerateResults;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RHPsicotest.WebSite.Repositories
{
    public class ExpedientRepository : IExpedientRepository
    {
        private readonly RHPsicotestDbContext context;

        public ExpedientRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> AddExpedient(ExpedientVM expedientVM, (string, string, string) currentCandidate)
        {
            bool result;

            Expedient expedient = Conversion.ConvertToExpedient(expedientVM, currentCandidate);

            await context.Expedients.AddAsync(expedient);
            result = await context.SaveChangesAsync() > 0;

            return result;
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
            List<Expedient> expedients = await context.Expedients.ToListAsync();

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

            return expedient.CurriculumVitae;
        }
        
        public async Task<List<ResultDTO>> GetResults(int expedientId)
        {
            List<Result> results = await context.Results.Where(e => e.IdExpedient == expedientId).ToListAsync();

            List<ResultDTO> resultDTOs = new List<ResultDTO>();

            bool isPPGIPG = true;

            foreach (Result result in results)
            {
                if(result.IdTest == 1 && isPPGIPG)
                {
                    List<Result> resultsPPGIPG = new List<Result>();

                    foreach (Result result2 in results)
                    {
                        if (result2.IdFactor <= 9)
                        {
                            resultsPPGIPG.Add(result2);
                        }
                    }
                    
                    resultDTOs.Add(Conversion.ConvertToResultDTO(result.IdTest, resultsPPGIPG));

                    isPPGIPG = false;
                }
                
                if (result.IdTest > 1)
                {
                    List<Result> results1 = new List<Result>
                    {
                        result
                    };

                    resultDTOs.Add(Conversion.ConvertToResultDTO(result.IdTest, results1));
                }
            }

            return resultDTOs;
        }

    }
}
