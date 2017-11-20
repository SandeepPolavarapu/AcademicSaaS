using AcademicSaaS.Models.Request;
using FluentValidation;

namespace AcademicSaaS.Validators
{
    public class SchoolClassRequestValidator : AbstractValidator<SchoolClassRequest>
    {
        public SchoolClassRequestValidator()
        {
            RuleFor(x => x.ClassId).NotEmpty().OverridePropertyName("classId").WithMessage("required");

            RuleFor(x => x.SectiondIds).NotEmpty().DependentRules(y =>
                    y.RuleFor(x => x.SectiondIds).Must((x, sectiondIds) => sectiondIds.Count > 2)
                    .WithMessage("At least 2 sections are required")
                ).OverridePropertyName("sectiondIds").WithMessage("required");

            RuleFor(x => x.SubjectIds).NotEmpty().DependentRules(y =>
                   y.RuleFor(x => x.SubjectIds).Must((x, studentIds) => studentIds.Count > 5)
                   .WithMessage("At least 5 subjects are required")
               ).OverridePropertyName("subjectIds").WithMessage("required");

            RuleFor(x => x.ClassTeacherId).NotEmpty().OverridePropertyName("classTeacherId").WithMessage("required");
        }
    }
}
