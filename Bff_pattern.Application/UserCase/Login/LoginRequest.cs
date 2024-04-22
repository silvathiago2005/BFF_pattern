using MediatR;

namespace Bff_pattern.Application.UserCase.Login
{
    public class LoginRequestCommand : IRequest<LoginResponseCommand>
    { 
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
