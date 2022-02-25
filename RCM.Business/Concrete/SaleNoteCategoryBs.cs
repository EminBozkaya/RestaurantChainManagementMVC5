using Core.DataAccess.Abstract;
using RCM.DataAccess.Abstract;
using RCM.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCM.Business.Concrete
{
    public class SaleNoteCategoryBs : BusinessBase<SaleNoteCategory>
    {
        private readonly ISaleNoteCategoryRepo _repo;
        public SaleNoteCategoryBs(ISaleNoteCategoryRepo repo) : base(repo)
        {
            _repo = repo;
        }
    }
}
