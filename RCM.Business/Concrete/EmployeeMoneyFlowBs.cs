using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class EmployeeMoneyFlowBs : BusinessBase<EmployeeMoneyFlow>
    {
        private readonly IEmployeeMoneyFlowRepo _repo;


        public EmployeeMoneyFlowBs(IEmployeeMoneyFlowRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
