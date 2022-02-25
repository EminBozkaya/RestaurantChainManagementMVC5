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
    public class FirmTypeMap : EntityTypeConfiguration<FirmType>
    {
        public FirmTypeMap()
        {
            ToTable(@"FirmType", @"dbo");

            HasKey(x => x.FTId);

            Property(x => x.FTId)
                .HasColumnName("FTId")
                .HasColumnType("tinyint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsOptional();

            
        }
    }
}
