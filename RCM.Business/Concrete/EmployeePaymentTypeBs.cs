using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class EmployeePaymentTypeBs : BusinessBase<EmployeePaymentType>
    {
        private readonly IEmployeePaymentTypeRepo _repo;


        public EmployeePaymentTypeBs(IEmployeePaymentTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
