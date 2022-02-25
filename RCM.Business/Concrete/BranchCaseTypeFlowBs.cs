using RCM.Model.Domain;
using RCM.DataAccess.Abstract;

namespace RCM.Business.Concrete
{
    public class BranchCaseTypeFlowBs : BusinessBase<BranchCaseTypeFlow>
    {
        private readonly IBranchCaseTypeFlowRepo _repo;

               
        public BranchCaseTypeFlowBs(IBranchCaseTypeFlowRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
