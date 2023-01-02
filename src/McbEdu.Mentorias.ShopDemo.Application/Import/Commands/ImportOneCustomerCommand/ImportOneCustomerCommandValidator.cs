using FluentValidation;

namespace McbEdu.Mentorias.ShopDemo.Application.Import.Commands.ImportOneCustomerCommand;

public class ImportOneCustomerCommandValidator : AbstractValidator<ImportOneCustomerCommand>
{
    public ImportOneCustomerCommandValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage("Please, specify a First Name.")
            .MaximumLength(50)
            .WithMessage("The length of {PropertyName} must be {MaxLength} characters or fewer. You entered {TotalLength} characters.");
        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("Please, specify a Last Name")
            .MaximumLength(150)
            .WithMessage("The length of {PropertyName} must be {MaxLength} characters or fewer. You entered {TotalLength} characters.");
        RuleFor(x => x.Email)
            .EmailAddress()
            .WithMessage("{PropertyName} is not a valid email address")
            .MaximumLength(256)
            .WithMessage("The length of {PropertyName} must be {MaxLength} characters or fewer. You entered {TotalLength} characters.");
        RuleFor(x => x.BirthDate).NotEmpty().WithMessage("Please, specify a Birth Date.");
    }
}