using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class BranchRevenueDistributionBs : BusinessBase<BranchRevenueDistribution>
    {
        private readonly IBranchRevenueDistributionRepo _repo;


        public BranchRevenueDistributionBs(IBranchRevenueDistributionRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
