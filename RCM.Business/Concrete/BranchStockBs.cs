using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class BranchStockBs : BusinessBase<BranchStock>
    {
        private readonly IBranchStockRepo _repo;


        public BranchStockBs(IBranchStockRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
