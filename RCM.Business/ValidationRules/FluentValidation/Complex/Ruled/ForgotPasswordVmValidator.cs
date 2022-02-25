using FluentValidation;
using RCM.Model.Complex.Login;

namespace RCM.Business.ValidationRules.FluentValidation.Complex.Ruled
{
    public class ForgotPasswordVmValidator : AbstractValidator<ForgotPasswordVm>
    {
        public ForgotPasswordVmValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("Ad boş bırakılamaz")
                .Length(2, 20)
                .WithMessage("Ad en az 2 karakter olmalıdır");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Soyad boş bırakılamaz")
                .Length(2, 20)
                .WithMessage("Soyad en az 2 karakter olmalıdır");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email boş bırakılamaz")
                .Matches(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$")
                //.EmailAddress()
                .WithMessage("Email adresi geçersiz");
        }
    }
}
