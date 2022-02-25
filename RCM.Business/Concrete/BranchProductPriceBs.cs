using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class BranchProductPriceBs : BusinessBase<BranchProductPrice>
    {
        private readonly IBranchProductPriceRepo _repo;


        public BranchProductPriceBs(IBranchProductPriceRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
