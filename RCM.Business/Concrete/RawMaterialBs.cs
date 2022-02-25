using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class RawMaterialBs : BusinessBase<RawMaterial>
    {
        private readonly IRawMaterialRepo _repo;


        public RawMaterialBs(IRawMaterialRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
