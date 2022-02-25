using FluentValidation;
using RCM.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCM.Business.ValidationRules.FluentValidation.Domain
{
    public class UserBranchAuthorityValidator : AbstractValidator<UserBranchAuthority>
    {
        public UserBranchAuthorityValidator()
        {
            RuleFor(x => x.UId)
                .NotEmpty()
                .WithMessage("Kullanıcı Id (UId) boş olamaz");

            RuleFor(x => x.BId)
                .NotEmpty()
                .WithMessage("Şube Id (BId) boş bırakılamaz");

            RuleFor(x => x.ATId)
                .NotEmpty()
                .WithMessage("Yetki tipi (ATId) adı boş bırakılamaz");

            RuleFor(x => x.IsActive)
                .NotEmpty()
                .WithMessage("Kullanıcı Aktif mi/Pasif mi belirtmelisiniz");

        }
    }
}
