using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories
{
    public class ExpedientRepository : IExpedientRepository
    {
        private readonly RHPsicotestDbContext context;

        public ExpedientRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> AddExpedient(ExpedientVM expedientVM)
        {
            bool existExpedient = await ExistsExpedient(expedientVM.Email);

            bool result = false;

            if(!existExpedient)
            {
                byte[] filePDFInBytes = Helper.FilePDFToBytes(expedientVM.CurriculumVitae);

                Expedient expedient = Conversion.ConvertToExpedient(expedientVM, filePDFInBytes);

                await context.Expedients.AddAsync(expedient);
                result =  await context.SaveChangesAsync() > 0;
            }

            return result;
        }
        
        private async Task<bool> ExistsExpedient(string email)
        {
            return await context.Expedients.AnyAsync(e => e.Email == email);
        }

        public async Task<IEnumerable<Expedient>> GetAllExpedients()
        {
            return await context.Expedients.ToListAsync();
        }

        public async Task<byte[]> GetPDFInBytes(int id)
        { 
            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdExpedient == id);

            return expedient.CurriculumVitae;
        }
    }
}
