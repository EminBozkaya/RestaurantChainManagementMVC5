using RCM.Model.Domain;
using RCM.DataAccess.Abstract;

namespace RCM.Business.Concrete
{
    public class BranchCaseTypeBs : BusinessBase<BranchCaseType>
    {
        private readonly IBranchCaseTypeRepo _repo;

               
        public BranchCaseTypeBs(IBranchCaseTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
