using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class UserBs : BusinessBase<User>
    {
        private readonly IUserRepo _repo;

        public UserBs(IUserRepo repo)
            : base(repo)
        {
            _repo = repo;
        }

        //---------special methods-(about user)----------
        public User GetByEmail(string email, params string[] includeList)
        {
            return _repo.Get(x => x.Email == email, includeList);
        }

        public User GetByEmailAndPassword(string email, string password, params string[] includeList)
        {
            return _repo.Get(x => x.Email == email && x.Password == password, includeList);
        }
    }
}
