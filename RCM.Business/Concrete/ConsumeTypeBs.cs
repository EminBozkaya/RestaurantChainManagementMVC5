using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class ConsumeTypeBs : BusinessBase<ConsumeType>
    {
        private readonly IConsumeTypeRepo _repo;


        public ConsumeTypeBs(IConsumeTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
