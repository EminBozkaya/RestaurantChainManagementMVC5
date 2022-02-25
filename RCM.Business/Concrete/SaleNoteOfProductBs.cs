using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class SaleNoteOfProductBs : BusinessBase<SaleNoteOfProduct>
    {
        private readonly ISaleNoteOfProductRepo _repo;


        public SaleNoteOfProductBs(ISaleNoteOfProductRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
