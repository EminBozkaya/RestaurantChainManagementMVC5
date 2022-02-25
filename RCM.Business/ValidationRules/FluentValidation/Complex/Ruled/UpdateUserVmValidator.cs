using FluentValidation;
using RCM.Model.Complex.DashBoard.SystemManagement.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCM.Business.ValidationRules.FluentValidation.Complex.Ruled
{
    public class UpdateUserVmValidator : AbstractValidator<UpdateUserVm>
    {
        public UpdateUserVmValidator()
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

            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("Kullanıcı adı boş bırakılamaz")
                .Length(4, 50)
                .WithMessage("Kullanıcı adı en az 4 karakter olmalıdır");

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

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Şifre boş bırakılamaz")
                .Length(4, 10)
                .WithMessage("Şifre en az 4 en fazla 10 karakter olmalıdır");

        }
    }
}
