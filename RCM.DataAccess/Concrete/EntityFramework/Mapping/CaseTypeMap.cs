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
    public class CaseTypeMap : EntityTypeConfiguration<CaseType>
    {
        public CaseTypeMap()
        {
            ToTable(@"CaseType", @"dbo");

            HasKey(x => x.CTId);

            Property(x => x.CTId)
                .HasColumnName("CTId")
                .HasColumnType("tinyint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .IsOptional();

            

        }
    }
}
