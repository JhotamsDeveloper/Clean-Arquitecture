using Clean.Arquitectucture.Aplication.Features.RegistrarUsuario.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Clean.Arquitecture.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")] //api/v1/user
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Crear Usuario")]
        [ProducesResponseType((int)HttpStatusCode.OK)] // 200
        public async Task<ActionResult<bool>> CrearUsuario([FromBody] RegistrarUsuarioCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
