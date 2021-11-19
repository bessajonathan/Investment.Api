using AutoMapper;
using Investment.Core.Dtos.User;
using Investment.Core.Entities;
using Investment.Core.Interfaces;
using System.Threading.Tasks;

namespace Investment.Core.UseCases
{
    public class UserUseCase : IUserUseCase
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserUseCase(IMapper mapper,IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task CreateUser(CreateUserDto createUserDto)
        {
            var newUser = _mapper.Map<User>(createUserDto);

            await _userRepository.CreateUser(newUser);
        }
    }
}
