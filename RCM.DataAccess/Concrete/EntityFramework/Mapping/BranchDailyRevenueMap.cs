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
    public class BranchDailyRevenueMap : EntityTypeConfiguration<BranchDailyRevenue>
    {
        public BranchDailyRevenueMap()
        {
            ToTable(@"BranchDailyRevenue", @"dbo");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.BId)
                .HasColumnName("BId")
                .HasColumnType("smallint")
                .IsRequired();

            Property(x => x.Date)
                .HasColumnName("Date")
                .HasColumnType("date")
                .IsRequired();

            Property(x => x.Amount)
                .HasColumnName("Amount")
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .IsOptional();

        }
    }
}
