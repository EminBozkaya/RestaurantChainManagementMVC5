using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class UserBranchAuthorityBs : BusinessBase<UserBranchAuthority>
    {
        private readonly IUserBranchAuthorityRepo _repo;


        public UserBranchAuthorityBs(IUserBranchAuthorityRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
