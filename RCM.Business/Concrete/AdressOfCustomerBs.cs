using RCM.Model.Domain;
using RCM.DataAccess.Abstract;

namespace RCM.Business.Concrete
{
    public class AdressOfCustomerBs : BusinessBase<AdressOfCustomer>
    {
        private readonly IAdressOfCustomerRepo _repo;

               
        public AdressOfCustomerBs(IAdressOfCustomerRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
