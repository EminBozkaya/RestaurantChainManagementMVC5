using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class SupplierMoneyFlowBs : BusinessBase<SupplierMoneyFlow>
    {
        private readonly ISupplierMoneyFlowRepo _repo;


        public SupplierMoneyFlowBs(ISupplierMoneyFlowRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
