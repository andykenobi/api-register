using ApiRegister.DTOs.Clients;
using FluentValidation;

namespace ApiRegister.Validations.Clients
{
    public class CreateClientValidation : AbstractValidator<CreateClientRequest>
    {
        public CreateClientValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name can not be empty.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email can not be empty.");
            RuleFor(x => x.Cep).NotEmpty().WithMessage("CEP can not be empty.");
            RuleFor(x => x.Birthday).NotEmpty().WithMessage("Birthday can not be empty.");
        }
    }
}
