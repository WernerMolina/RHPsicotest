using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IMergeRepository
    {
        public Task GenerateMergeDb();
    }
}
