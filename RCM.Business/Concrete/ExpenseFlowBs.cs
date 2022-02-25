using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class ExpenseFlowBs : BusinessBase<ExpenseFlow>
    {
        private readonly IExpenseFlowRepo _repo;


        public ExpenseFlowBs(IExpenseFlowRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
