using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class MyExceptionBs : BusinessBase<MyException>
    {
        private readonly IMyExceptionRepo _repo;
        public MyExceptionBs(IMyExceptionRepo repo)
            : base(repo)
        {
            _repo = repo;
        }

    }
}
