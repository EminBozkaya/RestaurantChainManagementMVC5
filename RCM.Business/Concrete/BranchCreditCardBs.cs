using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class BranchCreditCardBs : BusinessBase<BranchCreditCard>
    {
        private readonly IBranchCreditCardRepo _repo;


        public BranchCreditCardBs(IBranchCreditCardRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
