using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IExpedientRepository
    {
        public Task<List<ExpedientDTO>> GetAllExpedients();
        public Task<bool> AddExpedient(ExpedientVM expedientVM, (string, string, string) currentCandidate);
        public Task<bool> UpdateExpedient(ExpedientUpdateVM expedientUpdateVM);
        public Task<ExpedientUpdateVM> GetExpedientUpdateVM(int expedientId);
        public Task<byte[]> GetPDFInBytes(int id);
    }
}
