using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class BranchDailyRevenueBs : BusinessBase<BranchDailyRevenue>
    {
        private readonly IBranchDailyRevenueRepo _repo;


        public BranchDailyRevenueBs(IBranchDailyRevenueRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
