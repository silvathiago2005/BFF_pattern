using MediatR;

namespace Bff_pattern.Application.UserCase.Login
{
    public class LoginResponseCommand : IRequest<LoginRequestCommand>
    {
        public int Id { get; set; } 

        public string Name { get; set;}

        public string Token { get; set;}        
    }
}
