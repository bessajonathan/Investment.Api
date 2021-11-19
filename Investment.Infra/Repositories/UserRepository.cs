using Investment.Core.Entities;
using Investment.Core.Interfaces;
using System.Threading.Tasks;

namespace Investment.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IInvestmentDbContext _investmentDbContext;

        public UserRepository(IInvestmentDbContext investmentDbContext)
        {
            _investmentDbContext = investmentDbContext;
        }
        public async Task CreateUser(User newUser)
        {
            await _investmentDbContext.Users.AddAsync(newUser);
            await _investmentDbContext.SaveChangesAsync();
        }
    }
}
