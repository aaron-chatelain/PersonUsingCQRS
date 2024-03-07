using FluentValidation;
using PersonUsingCQRS.Application.Commands;
using PersonUsingCQRS.Models;

namespace PersonUsingCQRS.Controllers.Api.Validators
{
    public class AddPersonCommandValidator : AbstractValidator<AddPersonCommand>
    {
        public AddPersonCommandValidator()
        {
            When(p => string.IsNullOrEmpty(p.GivenName), () =>
            {
                RuleFor(p => p.Surname).NotEmpty();
            });
            When(p => string.IsNullOrEmpty(p.Surname), () =>
            {
                RuleFor(p => p.GivenName).NotEmpty();
            });
            RuleFor(p => p.Gender).NotEqual(Gender.None).NotEmpty();
        }
    }
}
