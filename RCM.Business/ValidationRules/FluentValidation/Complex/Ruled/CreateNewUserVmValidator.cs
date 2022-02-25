using FluentValidation;
using RCM.Model.Complex.DashBoard.SystemManagement.User;

namespace RCM.Business.ValidationRules.FluentValidation.Complex.Ruled
{
    public class CreateNewUserVmValidator : AbstractValidator<CreateNewUserVm>
    {
        public CreateNewUserVmValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("Ad boş bırakılamaz")
                .Length(2,20)
                .WithMessage("Ad en az 2 karakter olmalıdır");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Soyad boş bırakılamaz")
                .Length(2, 20)
                .WithMessage("Soyad en az 2 karakter olmalıdır");

            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage("Telefon numarası boş bırakılamaz")
                .Matches(@"^[1-9][0-9]{9}$")
                .WithMessage("Telefon numarasını başında SIFIR olmadan 10 karakter olacak şekilde sadece rakam giriniz");
            
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email boş bırakılamaz")
                .Matches(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$")
                //.EmailAddress()
                .WithMessage("Email geçerli değil");

            RuleFor(x => x.BranchID)
                .NotNull()
                .WithMessage("Şube seçmelisiniz");

            RuleFor(x => x.BranchID)
                .NotEqual("0")
                .WithMessage("Şube seçmelisiniz");

            RuleFor(x => x.AuthrtyID)
                .NotNull()
                .WithMessage("Yetki seçmelisiniz");

            RuleFor(x => x.AuthrtyID)
                .NotEqual("0")
                .WithMessage("Yetki seçmelisiniz");

        }
    }
}
