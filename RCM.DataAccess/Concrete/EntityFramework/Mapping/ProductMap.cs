using RCM.Model.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCM.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Product", @"dbo");

            HasKey(x => x.PId);

            Property(x => x.PId)
                .HasColumnName("PId")
                .HasColumnType("smallint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.CatId)
                .HasColumnName("CatId")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.Price)
                .HasColumnName("Price")
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .IsOptional();

            Property(x => x.VATpercent)
                .HasColumnName("VATpercent")
                .HasColumnType("float")
                .IsOptional();

            Property(x => x.TopPId)
                .HasColumnName("TopPId")
                .HasColumnType("smallint")
                .IsOptional();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();

            

        }
    }
}
