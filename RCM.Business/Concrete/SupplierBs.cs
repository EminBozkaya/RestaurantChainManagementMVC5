using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class SupplierBs : BusinessBase<Supplier>
    {
        private readonly ISupplierRepo _repo;


        public SupplierBs(ISupplierRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
