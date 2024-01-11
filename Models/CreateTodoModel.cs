using FluentValidation.Results;
using System.Runtime.Serialization;

namespace BindingDemo.Models;

public class CreateToDoModel
{
    // Should be bound
    public string Description { get; set; }

    // Should NOT be bound
    [IgnoreDataMember]
    public List<ValidationFailure>? Errors { get; set; }
}
