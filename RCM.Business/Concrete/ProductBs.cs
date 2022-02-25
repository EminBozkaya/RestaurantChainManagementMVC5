using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class ProductBs : BusinessBase<Product>
    {
        private readonly IProductRepo _repo;


        public ProductBs(IProductRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
