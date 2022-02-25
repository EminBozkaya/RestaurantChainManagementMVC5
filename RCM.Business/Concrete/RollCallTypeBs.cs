using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class RollCallTypeBs : BusinessBase<RollCallType>
    {
        private readonly IRollCallTypeRepo _repo;


        public RollCallTypeBs(IRollCallTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
