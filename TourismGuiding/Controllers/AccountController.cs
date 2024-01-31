
using Microsoft.AspNetCore.Mvc;
using TourismGuiding.Application.Features.Account.Loginn;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace TourismGuiding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator mediator;

        public AccountController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpPost("LoginAdmin")]
        public async Task<IActionResult> Login(AccountLoginRequest login)
        {

            var response = await mediator.Send(login);

            return Ok(response.Token);
        }

        [HttpGet("getTest")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetTest()
        {
            return Ok("Authorize");
        }
    }
}
