using Investment.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Investment.Core.Interfaces
{
    public interface IInvestmentDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Active> Actives { get; set; }
        DbSet<UserActive> UserActives { get; set; }
        DbSet<Wallet> Wallets { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
