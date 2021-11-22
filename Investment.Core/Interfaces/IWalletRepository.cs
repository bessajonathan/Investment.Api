using Investment.Core.Entities;
using System.Threading.Tasks;

namespace Investment.Core.Interfaces
{
    public interface IWalletRepository
    {
        Task Update(Wallet wallet);
        Task<Wallet> GetWalletByFirebaseId(string firebaseId);
    }
}
