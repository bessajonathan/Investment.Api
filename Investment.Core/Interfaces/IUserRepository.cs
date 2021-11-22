using Investment.Core.Entities;
using System.Threading.Tasks;

namespace Investment.Core.Interfaces
{
    public interface IUserRepository
    {
        Task CreateUser(User newUser);
        Task<bool> VerifyIfUserExistByFirebaseId(string firebaseId);
        Task<User> GetUserByFirebaseId(string firebaseId);
    }
}
