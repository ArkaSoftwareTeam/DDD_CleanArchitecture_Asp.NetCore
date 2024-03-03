using FluentValidation;
using Hesabdari.Sample.Core.Contracts.Pepole.Commands;
using Hesabdari.Sample.Core.Domain;


namespace Hesabdari.Sample.Core.ApplicationServices.Pepole.Commands.CreatePersonHandler
{
    public class CreatePersonValidator : AbstractValidator<CreatePerson>
    {
        public CreatePersonValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage(Messages.InvalidNullValue);
            RuleFor(c => c.LastName).NotEmpty().WithMessage(Messages.InvalidNullValue);
        }
    }
}
