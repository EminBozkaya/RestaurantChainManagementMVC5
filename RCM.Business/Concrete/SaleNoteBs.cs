using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class SaleNoteBs : BusinessBase<SaleNote>
    {
        private readonly ISaleNoteRepo _repo;


        public SaleNoteBs(ISaleNoteRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
