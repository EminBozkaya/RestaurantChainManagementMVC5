using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class EmployeeBs : BusinessBase<Employee>
    {
        private readonly IEmployeeRepo _repo;


        public EmployeeBs(IEmployeeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
