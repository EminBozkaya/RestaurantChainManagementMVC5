using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class RawMaterialOfProductBs : BusinessBase<RawMaterialOfProduct>
    {
        private readonly IRawMaterialOfProductRepo _repo;


        public RawMaterialOfProductBs(IRawMaterialOfProductRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
