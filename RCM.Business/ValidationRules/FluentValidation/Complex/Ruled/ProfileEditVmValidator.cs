using FluentValidation;
using RCM.Model.Complex.DashBoard.ChangesByUser.UserInfo;

namespace RCM.Business.ValidationRules.FluentValidation.Complex.Ruled
{
    public class ProfileEditVmValidator : AbstractValidator<ProfileEditVm>
    {
        public ProfileEditVmValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("Kullanıcı adı boş bırakılamaz")
                .Length(4,50)
                .WithMessage("Kullanıcı adı en az 4 karakter olmalıdır");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email boş bırakılamaz")
                .Matches(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$")
                //.EmailAddress()
                .WithMessage("Email geçerli değil");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Şifre boş bırakılamaz")
                .Length(4,10)
                .WithMessage("Şifre en az 4 en fazla 10 karakter olmalıdır");

        }
    }
}
