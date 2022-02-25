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
    public class SaleTypeMap : EntityTypeConfiguration<SaleType>
    {
        public SaleTypeMap()
        {
            ToTable(@"SaleType", @"dbo");

            HasKey(x => x.STId);

            Property(x => x.STId)
                .HasColumnName("STId")
                .HasColumnType("tinyint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Type)
                .HasColumnName("Type")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.TopSTId)
                .HasColumnName("TopSTId")
                .HasColumnType("tinyint")
                .IsOptional();

            Property(x => x.CutOffRate)
                .HasColumnName("CutOffRate")
                .HasColumnType("float")
                .IsOptional();

            

        }
    }
}
