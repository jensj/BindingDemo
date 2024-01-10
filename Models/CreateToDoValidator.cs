using FluentValidation;

namespace BindingDemo.Models;

public class CreateToDoValidator : AbstractValidator<CreateToDoModel>
{
    public CreateToDoValidator()
    {
        RuleFor(x => x.Description).NotEmpty();
        RuleFor(x => x.Description).MinimumLength(5);
    }
}