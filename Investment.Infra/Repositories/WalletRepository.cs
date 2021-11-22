using Investment.Core.Dtos.Wallet;
using Investment.Core.Entities;
using Investment.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Infra.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly IInvestmentDbContext _investmentDbContext;

        public WalletRepository(IInvestmentDbContext investmentDbContext)
        {
            _investmentDbContext = investmentDbContext;
        }

        public async Task<Wallet> GetWalletByFirebaseId(string firebaseId)
        {
            return await _investmentDbContext.Wallets
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.User.FirebaseId == firebaseId);
        }

        public async Task Update(Wallet wallet)
        {
            _investmentDbContext.Wallets.Update(wallet);
            await _investmentDbContext.SaveChangesAsync();
        }
    }
}
