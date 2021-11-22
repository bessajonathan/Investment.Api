using Investment.Attributes;
using Investment.Core.Dtos.User;
using Investment.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Investment.Api.Controllers
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : BaseController
    {
        /// <summary>
        /// Cadastra usuário na base caso não exista
        /// </summary>
        /// <param name="userUseCase"></param>
        /// <param name="createUserDto"></param>
        /// <returns></returns>
        [ApiKey]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateUser([FromServices] IUserUseCase userUseCase, [FromBody] CreateUserDto createUserDto)
        {
            await userUseCase.CreateUser(createUserDto);
            return Created(string.Empty,null);
        }
        /// <summary>
        /// Retorna o usuário logado
        /// </summary>
        /// <param name="userUseCase"></param>
        /// <returns></returns>
        [Authorize("Bearer")]
        [HttpGet]
        [ProducesResponseType(typeof(UserDto),(int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetUser([FromServices] IUserUseCase userUseCase)
        {
            return Ok(await userUseCase.GetUser(FirebaseId));
        }
    }
}
