using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class ProductCategoryBs : BusinessBase<ProductCategory>
    {
        private readonly IProductCategoryRepo _repo;


        public ProductCategoryBs(IProductCategoryRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
