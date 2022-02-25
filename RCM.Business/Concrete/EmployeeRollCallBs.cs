using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class EmployeeRollCallBs : BusinessBase<EmployeeRollCall>
    {
        private readonly IEmployeeRollCallRepo _repo;


        public EmployeeRollCallBs(IEmployeeRollCallRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
