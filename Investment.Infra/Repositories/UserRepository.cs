using Investment.Core.Entities;
using Investment.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<User> GetUserByFirebaseId(string firebaseId)
        {
            return await _investmentDbContext.Users
                .Include(x => x.Wallet)
                .Include(x => x.Actives)
                .ThenInclude(y => y.Active)
                .FirstOrDefaultAsync(x => x.FirebaseId == firebaseId);
        }

        public async Task<bool> VerifyIfUserExistByFirebaseId(string firebaseId)
        {
            return await _investmentDbContext
                .Users.AnyAsync(x => x.FirebaseId == firebaseId);
        }
    }
}
