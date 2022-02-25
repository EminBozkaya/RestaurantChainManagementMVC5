using FluentValidation;
using RCM.Model.Complex.Login;

namespace RCM.Business.ValidationRules.FluentValidation.Complex.Ruled
{
    public class LogInVmValidator : AbstractValidator<LogInVm>
    {
        public LogInVmValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("Kullanıcı adı boş bırakılamaz")
                .Length(4, 50)
                .WithMessage("Kullanıcı adı en az 4 karakter olmalıdır");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Şifre boş bırakılamaz")
                .Length(4, 10)
                .WithMessage("Şifre en az 4, en fazla 10 karakter olmalıdır");
        }
    }
}
