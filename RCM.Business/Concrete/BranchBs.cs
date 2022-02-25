using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class BranchBs : BusinessBase<Branch>
    {
        private readonly IBranchRepo _repo;


        public BranchBs(IBranchRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
