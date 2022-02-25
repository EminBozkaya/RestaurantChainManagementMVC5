using Core.DataAccess.Concrete.EntityFramework;
using RCM.DataAccess.Abstract;
using RCM.DataAccess.Concrete.EntityFramework.Context;
using RCM.Model.Domain;
using System.Collections.Generic;
using System.Linq;

namespace RCM.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfUserRepo : EfRepositoryBase<RCMContext, User>, IUserRepo
    {
        public List<User> GetByAuthorityTypeId(byte ATId)
        {
            return
                base.GetAll(x => x.UserBranchAuthorities
                    .Select(y => y.ATId)
                    .Contains(ATId))
                    .ToList();
        }
    }
}
