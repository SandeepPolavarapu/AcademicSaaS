using AcademicSaaS.Models.Request;
using FluentValidation;

namespace AcademicSaaS.Validators
{
    public class ApiRequestValidator : AbstractValidator<ApiRequest>
    {
        public ApiRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().OverridePropertyName("name").WithMessage("required");
        }
    }
}
