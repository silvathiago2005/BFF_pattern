using MediatR;

namespace Bff_pattern.Application.UserCase.Reset
{
    public class ResetPasswordResquestCommand : IRequest<ResetPasswordResponseCommand>
    {
        public int Id { get; set; }

        public string OldPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
