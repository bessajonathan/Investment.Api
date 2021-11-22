using Investment.Core.Entities;
using Investment.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Investment.Infra.Data
{
    public class InvestmentDbContext : DbContext, IInvestmentDbContext
    {
        public InvestmentDbContext(DbContextOptions<InvestmentDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get ; set; }
        public DbSet<Active> Actives { get ; set; }
        public DbSet<UserActive> UserActives { get ; set; }
        public DbSet<Wallet> Wallets { get ; set; }
    }
}
