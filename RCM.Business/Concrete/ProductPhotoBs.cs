using RCM.DataAccess.Abstract;
using RCM.Model.Domain;

namespace RCM.Business.Concrete
{
    public class ProductPhotoBs : BusinessBase<ProductPhoto>
    {
        private readonly IProductPhotoRepo _repo;


        public ProductPhotoBs(IProductPhotoRepo repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
