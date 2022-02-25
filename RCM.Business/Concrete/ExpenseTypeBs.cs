using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class ExpenseTypeBs : BusinessBase<ExpenseType>
    {
        private readonly IExpenseTypeRepo _repo;


        public ExpenseTypeBs(IExpenseTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
