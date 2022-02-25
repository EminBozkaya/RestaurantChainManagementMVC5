using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class FirmTypeBs : BusinessBase<FirmType>
    {
        private readonly IFirmTypeRepo _repo;


        public FirmTypeBs(IFirmTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
