using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class PositionTypeBs : BusinessBase<PositionType>
    {
        private readonly IPositionTypeRepo _repo;


        public PositionTypeBs(IPositionTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
