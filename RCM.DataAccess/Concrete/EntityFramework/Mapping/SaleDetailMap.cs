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
    public class SaleDetailMap : EntityTypeConfiguration<SaleDetail>
    {
        public SaleDetailMap()
        {
            ToTable(@"SaleDetail", @"dbo");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .IsRequired();

            Property(x => x.SId)
                .HasColumnName("SId")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.PId)
                .HasColumnName("PId")
                .HasColumnType("smallint")
                .IsRequired();

            Property(x => x.Price)
                .HasColumnName("Price")
                .HasColumnType("smallmoney")
                .HasPrecision(10, 4)
                .IsRequired();

            Property(x => x.Qty)
                .HasColumnName("Qty")
                .HasColumnType("tinyint")
                .IsRequired();            

            Property(x => x.Portion)
                .HasColumnName("Portion")
                .HasColumnType("float")
                .IsRequired();

            Property(x => x.Total)
                .HasColumnName("Total")
                .HasColumnType("smallmoney")
                .HasPrecision(10, 4)
                .IsRequired();

            Property(x => x.Note)
                .HasColumnName("Note")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsOptional();

            Property(x => x.CutOff)
                .HasColumnName("CutOff")
                .HasColumnType("smallmoney")
                .HasPrecision(10, 4)
                .IsOptional();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("int")
                .IsOptional();

            Property(x => x.ModifiedTime)
                .HasColumnName("ModifiedTime")
                .HasColumnType("smalldatetime")
                .IsOptional();

        }
    }
}
