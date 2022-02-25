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
    public class AuthorityTypeMap : EntityTypeConfiguration<AuthorityType>
    {
        
        public AuthorityTypeMap()
        {
            ToTable(@"AuthorityType", @"dbo");

            HasKey(x => x.ATId);

            Property(x => x.ATId)
                .HasColumnName("ATId")
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
