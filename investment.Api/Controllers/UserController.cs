using Investment.Core.Dtos.User;
using Investment.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Investment.Api.Controllers
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : Controller
    {
        /// <summary>
        /// Cadastra usuário na base
        /// </summary>
        /// <param name="userUseCase"></param>
        /// <param name="createUserDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromServices] IUserUseCase userUseCase, [FromBody] CreateUserDto createUserDto)
        {
            await userUseCase.CreateUser(createUserDto);
            return Created(string.Empty,null);
        }
    }
}
