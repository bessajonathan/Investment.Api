using Investment.Common.Exceptions;
using Investment.Core.Interfaces;
using Investment.Core.Providers.Bc.Response;
using System;
using System.Threading.Tasks;

namespace Investment.Core.UseCases
{
    public class WalletUseCase : IWalletUseCase
    {
        private readonly IWalletRepository _walletRepository;

        public WalletUseCase(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public IWalletRepository WalletRepository { get; }

        public async Task Deposit(BcResponse deposit)
        {
            var wallet = await _walletRepository.GetWalletByFirebaseId(deposit.FirebaseId);

            if (wallet == null)
                throw new NotFoundException("Carteira não encontrada");

            wallet.Amount += deposit.Amount;

            await _walletRepository.Update(wallet);
        }
    }
}
