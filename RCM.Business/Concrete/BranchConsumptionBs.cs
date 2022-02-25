using RCM.Model.Domain;
using RCM.DataAccess.Abstract;

namespace RCM.Business.Concrete
{
    public class BranchConsumptionBs : BusinessBase<BranchConsumption>
    {
        private readonly IBranchConsumptionRepo _repo;

               
        public BranchConsumptionBs(IBranchConsumptionRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
