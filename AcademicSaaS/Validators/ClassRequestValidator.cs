using AcademicSaaS.Models.Request;
using FluentValidation;

namespace AcademicSaaS.Validators
{
    public class ClassRequestValidator : AbstractValidator<ClassRequest>
    {
        public ClassRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().OverridePropertyName("name").WithMessage("required");
            RuleFor(x => x.SchoolId).NotEmpty().OverridePropertyName("schoolId").WithMessage("required");
        }
    }
}
