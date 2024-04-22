using MediatR;

namespace Bff_pattern.Application.UserCase.Reset
{
    public class ResetPasswordUsercase : IRequestHandler<ResetPasswordResquestCommand, ResetPasswordResponseCommand>
    {
        public Task<ResetPasswordResponseCommand> Handle(ResetPasswordResquestCommand req, CancellationToken cancellationToken)
        {
            ResetPasswordResponseCommand response = new ResetPasswordResponseCommand();

            return Task.FromResult(response);
        }
    }
}
