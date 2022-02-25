using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class SaleBs : BusinessBase<Sale>
    {
        private readonly ISaleRepo _repo;


        public SaleBs(ISaleRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
