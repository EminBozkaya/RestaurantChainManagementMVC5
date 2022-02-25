using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class BranchStockEntryBs : BusinessBase<BranchStockEntry>
    {
        private readonly IBranchStockEntryRepo _repo;


        public BranchStockEntryBs(IBranchStockEntryRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
