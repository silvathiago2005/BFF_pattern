using Microsoft.AspNetCore.Mvc;
using MediatR;
using Bff_pattern.Application.UserCase.Login;
using Bff_pattern.Application.UserCase.Reset;

namespace Bff_Pattern.Controller
{
    [ApiController]
    [Route("api/v1/")]
    public class LoginController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "Login")]
        public async Task<IActionResult> Login(LoginRequestCommand request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpGet(Name = "ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordResquestCommand passwordRequest)
        {
            var response = await _mediator.Send(passwordRequest);

            return Ok(response);
        }
    }
        
}
