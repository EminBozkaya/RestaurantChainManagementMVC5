using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class CustomerBs : BusinessBase<Customer>
    {
        private readonly ICustomerRepo _repo;


        public CustomerBs(ICustomerRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
