using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class SaleTypeBs : BusinessBase<SaleType>
    {
        private readonly ISaleTypeRepo _repo;


        public SaleTypeBs(ISaleTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
