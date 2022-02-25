using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class SalaryTypeBs : BusinessBase<SalaryType>
    {
        private readonly ISalaryTypeRepo _repo;


        public SalaryTypeBs(ISalaryTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
