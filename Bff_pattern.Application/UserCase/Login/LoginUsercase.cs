using MediatR;

namespace Bff_pattern.Application.UserCase.Login
{
    public class LoginUsercase : IRequestHandler<LoginRequestCommand, LoginResponseCommand>
    {

        public Task<LoginResponseCommand> Handle(LoginRequestCommand request, CancellationToken cancellationToken)
        {
            LoginResponseCommand response = new LoginResponseCommand();

            if (request != null && request.Username == "silvathiago2005" && request.Password == "Oficin@g3")
            {
                response.Id = 1;
                response.Name = "Thiago Lopes da Silva";
                response.Token = "silvathiago2005";
            }
            
            return Task.FromResult(response);
        }
    }
}
