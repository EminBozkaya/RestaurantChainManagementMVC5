using RCM.Model.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCM.DataAccess.Concrete.EntityFramework.Mapping
{
    public class RawMaterialOfProductMap : EntityTypeConfiguration<RawMaterialOfProduct>
    {
        public RawMaterialOfProductMap()
        {
            ToTable(@"RawMaterialOfProduct", @"dbo");

            HasKey(x => x.PId);

            Property(x => x.PId)
                .HasColumnName("PId")
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

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();

        }
    }
}
