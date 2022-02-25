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
    public class RawMaterialMap : EntityTypeConfiguration<RawMaterial>
    {
        public RawMaterialMap()
        {
            ToTable(@"RawMaterial", @"dbo");

            HasKey(x => x.RMId);

            Property(x => x.RMId)
                .HasColumnName("RMId")
                .HasColumnType("smallint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.UnitName)
                .HasColumnName("UnitName")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsOptional();

            Property(x => x.VATpercent)
                .HasColumnName("VATpercent")
                .HasColumnType("tinyint")
                .IsOptional();

            
        }
    }
}
