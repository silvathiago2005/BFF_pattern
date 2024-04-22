using MediatR;

namespace Bff_pattern.Application.UserCase.Reset
{
    public class ResetPasswordResponseCommand : IRequest<ResetPasswordResquestCommand>
    {
        public int Id { get; set; }

        public string NewPassword {  get; set; }    
    }
}
