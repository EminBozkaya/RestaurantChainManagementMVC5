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
    public class BranchProductPriceMap : EntityTypeConfiguration<BranchProductPrice>
    {
        public BranchProductPriceMap()
        {
            ToTable(@"BranchProductPrice", @"dbo");

            HasKey(x => x.PId);

            Property(x => x.PId)
                .HasColumnName("Id")
                .HasColumnType("smallint")
                .IsRequired();

            HasKey(x => x.BId);

            Property(x => x.BId)
                .HasColumnName("BId")
                .HasColumnType("smallint")
                .IsRequired();

            Property(x => x.BranchPrice)
                .HasColumnName("BranchPrice")
                .HasColumnType("smallmoney")
                .HasPrecision(10, 4)
                .IsRequired();

            Property(x => x.VATpercent)
                .HasColumnName("VATpercent")
                .HasColumnType("float")
                .IsOptional();

            Property(x => x.IsFavorite)
                .HasColumnName("IsFavorite")
                .HasColumnType("bit")
                .IsOptional();

        }
    }
}
