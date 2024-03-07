using FluentValidation;
using PersonUsingCQRS.Application.Commands;
using PersonUsingCQRS.Models;

namespace PersonUsingCQRS.Controllers.Api.Validators
{
    public class RecordBirthCommandValidator : AbstractValidator<RecordBirthCommand>
    {
        public RecordBirthCommandValidator()
        {   
            RuleFor(p => p.BirthDate).Must(x => x > default(DateTime)).WithMessage("Birth Date must have a value");
            RuleFor(p => p.BirthLocation).NotEmpty();
        }
    }
}
