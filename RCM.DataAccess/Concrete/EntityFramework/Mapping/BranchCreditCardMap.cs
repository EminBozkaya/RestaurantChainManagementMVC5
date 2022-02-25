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
    public class BranchCreditCardMap : EntityTypeConfiguration<BranchCreditCard>
    {
        public BranchCreditCardMap()
        {
            ToTable(@"BranchCreditCard", @"dbo");

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("smallint")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasKey(x => x.BId);

            Property(x => x.BId)
                .HasColumnName("BId")
                .HasColumnType("smallint")
                .IsRequired();

            HasKey(x => x.CCId);

            Property(x => x.CCId)
                .HasColumnName("CCId")
                .HasColumnType("tinyint")
                .IsRequired();

            HasKey(x => x.IsActive);

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.CardDept)
                .HasColumnName("CardDept")
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .IsOptional();
                        
            Property(x => x.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("int")
                .IsOptional();

            Property(x => x.Date)
                .HasColumnName("Date")
                .HasColumnType("date")
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
