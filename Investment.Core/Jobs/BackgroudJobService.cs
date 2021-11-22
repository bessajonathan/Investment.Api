using Investment.Core.Interfaces;
using System.Threading.Tasks;

namespace Investment.Core.Jobs
{
    public class BackgroudJobService : IBackgroudJobService
    {
        private readonly IBcProvider _bcProvider;
        private readonly IWalletUseCase _walletUseCase;

        public BackgroudJobService(IBcProvider bcProvider,IWalletUseCase walletUseCase)
        {
            _bcProvider = bcProvider;
            _walletUseCase = walletUseCase;
        }

        public async Task VerifyDeposits()
        {
            var deposit = await _bcProvider.GetDeposit();

            if (deposit != null)
            {
                await _walletUseCase.Deposit(deposit);
            }
        }
    }
}
