using System.Threading.Tasks;

namespace SibsStore.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
