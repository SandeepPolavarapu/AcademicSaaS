using AcademicSaaS.Models.Request;
using FluentValidation;

namespace AcademicSaaS.Validators
{
    public class SectionStudentRequestValidator : AbstractValidator<SectionStudentRequest>
    {
        public SectionStudentRequestValidator()
        {
            RuleFor(x => x.SectionId).NotEmpty().OverridePropertyName("sectiondId").WithMessage("required");
            RuleFor(x => x.StudentIds).NotEmpty().DependentRules(y =>
                    y.RuleFor(x => x.StudentIds).Must((x, studentIds) => studentIds.Count > 5)
                    .WithMessage("At least 5 students are required")
                ).OverridePropertyName("studentIds").WithMessage("required");
        }
    }
}
