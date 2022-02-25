using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class SaleDetailBs : BusinessBase<SaleDetail>
    {
        private readonly ISaleDetailRepo _repo;


        public SaleDetailBs(ISaleDetailRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
