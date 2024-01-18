using ApiRegister.DTOs.Clients;
using FluentValidation;

namespace ApiRegister.Validations.Clients
{
    public class UpdateClientValidation : AbstractValidator<UpdateClientRequest>
    {
        public UpdateClientValidation()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id can not be empty.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name can not be empty.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email can not be empty.");
            RuleFor(x => x.Cep).NotEmpty().WithMessage("CEP can not be empty.");
            RuleFor(x => x.Birthday).NotEmpty().WithMessage("Birthday can not be empty.");
        }
    }
}
