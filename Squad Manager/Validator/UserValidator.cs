using FluentValidation;
using Squad_Manager.Models;

namespace Squad_Manager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() 
        {
            RuleFor(user => user.Email).NotNull().WithMessage("Email vazio");
            RuleFor(user => user.Email).EmailAddress().WithMessage("O email eh invalido");
            RuleFor(user => user.Password).NotNull().WithMessage("Digite a senha");
        }
    }
}
