using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class WorkTypeBs : BusinessBase<WorkType>
    {
        private readonly IWorkTypeRepo _repo;


        public WorkTypeBs(IWorkTypeRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
