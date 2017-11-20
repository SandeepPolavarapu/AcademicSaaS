using AcademicSaaS.Models.Request;
using FluentValidation;

namespace AcademicSaaS.Validators
{
    public class PersonRequestValidator : AbstractValidator<PersonRequest>
    {
        public PersonRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().OverridePropertyName("name").WithMessage("required");
            RuleFor(x => x.SchoolId).NotEmpty().OverridePropertyName("schoolId").WithMessage("required");
            RuleFor(x => x.Role).NotEmpty().DependentRules(y =>
                        y.RuleFor(x => x.Role).IsInEnum().WithMessage("Not a valid role")
                ).OverridePropertyName("role").WithMessage("required");

        }
    }
}
