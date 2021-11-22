using Investment.Core.Providers.Bc.Response;
using System.Threading.Tasks;

namespace Investment.Core.Interfaces
{
    public interface IBcProvider
    {
        Task<BcResponse> GetDeposit();
    }
}
