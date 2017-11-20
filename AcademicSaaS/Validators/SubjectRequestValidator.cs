using AcademicSaaS.Models.Request;
using FluentValidation;

namespace AcademicSaaS.Validators
{
    public class SubjectRequestValidator : AbstractValidator<SubjectRequest>
    {
        public SubjectRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().OverridePropertyName("name").WithMessage("required");
            RuleFor(x => x.SchoolId).NotEmpty().OverridePropertyName("schoolId").WithMessage("required");
        }
    }
}
