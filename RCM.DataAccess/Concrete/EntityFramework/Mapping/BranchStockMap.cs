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
    public class BranchStockMap : EntityTypeConfiguration<BranchStock>
    {
        public BranchStockMap()
        {
            ToTable(@"BranchStock", @"dbo");

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            HasKey(x => x.BId);

            Property(x => x.BId)
                .HasColumnName("BId")
                .HasColumnType("smallint")
                .IsRequired();

            HasKey(x => x.RMId);

            Property(x => x.RMId)
                .HasColumnName("RMId")
                .HasColumnType("smallint")
                .IsRequired();

            Property(x => x.RMQty)
                .HasColumnName("RMQty")
                .HasColumnType("float")
                .IsRequired();

            Property(x => x.BasePrice)
                .HasColumnName("BasePrice")
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .IsRequired();

            Property(x => x.VATpercent)
                .HasColumnName("VATpercent")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.Brand)
                .HasColumnName("Brand")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("int")
                .IsOptional();

            Property(x => x.ModifiedTime)
                .HasColumnName("ModifiedTime")
                .HasColumnType("smalldatetime")
                .IsOptional();

            Property(x => x.IsShowItem)
                .HasColumnName("IsShowItem")
                .HasColumnType("bit")
                .IsOptional();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.IpAdress)
                .HasColumnName("IpAdress")
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsRequired();

        }
    }
}
