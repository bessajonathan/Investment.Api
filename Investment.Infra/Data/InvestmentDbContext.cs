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
    }
}
