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
    public class BranchCaseTypeMap : EntityTypeConfiguration<BranchCaseType>
    {
        public BranchCaseTypeMap()
        {
            ToTable(@"BranchCaseType", @"dbo");

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

            HasKey(x => x.CTId);

            Property(x => x.CTId)
                .HasColumnName("CTId")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.Amount)
                .HasColumnName("Amount")
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .IsRequired();
            
            HasKey(x => x.IsActive);

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();
                        
            Property(x => x.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.Date)
                .HasColumnName("Date")
                .HasColumnType("smalldatetime")
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
