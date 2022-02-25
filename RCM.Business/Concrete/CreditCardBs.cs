using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class CreditCardBs : BusinessBase<CreditCard>
    {
        private readonly ICreditCardRepo _repo;


        public CreditCardBs(ICreditCardRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
