using RCM.Model.Domain;
using RCM.DataAccess.Abstract;

namespace RCM.Business.Concrete
{
    public class AuthorityTypeBs : BusinessBase<AuthorityType>
    {
        private readonly IAuthorityTypeRepo _repo;

               
        public AuthorityTypeBs(IAuthorityTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
