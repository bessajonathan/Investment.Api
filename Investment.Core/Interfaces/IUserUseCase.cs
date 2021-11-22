using Investment.Core.Dtos.User;
using System.Threading.Tasks;

namespace Investment.Core.Interfaces
{
    public interface IUserUseCase
    {
        Task CreateUser(CreateUserDto createUserDto);
        Task<UserDto> GetUser(string firebaseId);
    }
}
