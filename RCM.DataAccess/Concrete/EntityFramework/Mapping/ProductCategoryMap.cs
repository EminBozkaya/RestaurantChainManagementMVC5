using RCM.Model.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RCM.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ProductCategoryMap : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryMap()
        {
            ToTable(@"ProductCategory", @"dbo");

            HasKey(x => x.CatId);

            Property(x => x.CatId)
                .HasColumnName("CatId")
                .HasColumnType("tinyint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsRequired();

            

        }
    }
}
