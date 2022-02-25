using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class CaseTypeBs : BusinessBase<CaseType>
    {
        private readonly ICaseTypeRepo _repo;


        public CaseTypeBs(ICaseTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
