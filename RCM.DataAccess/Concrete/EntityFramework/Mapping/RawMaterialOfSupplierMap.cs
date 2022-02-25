using RCM.Model.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCM.DataAccess.Concrete.EntityFramework.Mapping
{
    public class RawMaterialOfSupplierMap : EntityTypeConfiguration<RawMaterialOfSupplier>
    {
        public RawMaterialOfSupplierMap()
        {
            ToTable(@"RawMaterialOfSupplier", @"dbo");

            HasKey(x => x.SpId);

            Property(x => x.SpId)
                .HasColumnName("SpId")
                .HasColumnType("int")
                .IsRequired();

            HasKey(x => x.RMId);

            Property(x => x.RMId)
                .HasColumnName("RMId")
                .HasColumnType("smallint")
                .IsRequired();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();

        }
    }
}
