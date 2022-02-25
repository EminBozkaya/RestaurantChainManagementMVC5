using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class BranchCreditCardFlowBs : BusinessBase<BranchCreditCardFlow>
    {
        private readonly IBranchCreditCardFlowRepo _repo;


        public BranchCreditCardFlowBs(IBranchCreditCardFlowRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
