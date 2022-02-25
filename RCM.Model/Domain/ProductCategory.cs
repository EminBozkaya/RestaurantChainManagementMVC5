using Core.Model;
using System.Collections.Generic;

namespace RCM.Model.Domain
{
    public class ProductCategory : BaseDomain
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }

        public byte CatId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
