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
    public class ConsumeTypeMap : EntityTypeConfiguration<ConsumeType>
    {
        public ConsumeTypeMap()
        {
            ToTable(@"ConsumeType", @"dbo");

            HasKey(x => x.ConsTId);

            Property(x => x.ConsTId)
                .HasColumnName("ConsTId")
                .HasColumnType("tinyint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Type)
                .HasColumnName("Type")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsOptional();

            
        }

    }
}
