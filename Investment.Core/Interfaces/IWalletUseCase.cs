using Investment.Core.Providers.Bc.Response;
using System.Threading.Tasks;

namespace Investment.Core.Interfaces
{
    public interface IWalletUseCase
    {
        Task Deposit(BcResponse deposit);
    }
}
