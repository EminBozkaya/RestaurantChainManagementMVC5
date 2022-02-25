using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class RawMaterialOfSupplierBs : BusinessBase<RawMaterialOfSupplier>
    {
        private readonly IRawMaterialOfSupplierRepo _repo;


        public RawMaterialOfSupplierBs(IRawMaterialOfSupplierRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
