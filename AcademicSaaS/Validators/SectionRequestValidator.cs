using AcademicSaaS.Models.Request;
using FluentValidation;

namespace AcademicSaaS.Validators
{
    public class SectionRequestValidator : AbstractValidator<SectionRequest>
    {
        public SectionRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().OverridePropertyName("name").WithMessage("required");
            RuleFor(x => x.SchoolId).NotEmpty().OverridePropertyName("schoolId").WithMessage("required");
        }
    }
}
