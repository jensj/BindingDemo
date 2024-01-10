using FluentValidation.Results;

namespace BindingDemo.Models;

public class CreateToDoModel
{
    // Should be bound
    public string Description { get; set; }

    // Should NOT be bound
    public List<ValidationFailure>? Errors { get; set; }
}