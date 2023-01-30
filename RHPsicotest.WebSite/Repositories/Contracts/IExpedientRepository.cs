using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IExpedientRepository
    {
        public Task<IEnumerable<Expedient>> GetAllExpedients();
        public Task<bool> AddExpedient(ExpedientVM expedientVM);
        public Task<byte[]> GetPDFInBytes(int id);
    }
}
