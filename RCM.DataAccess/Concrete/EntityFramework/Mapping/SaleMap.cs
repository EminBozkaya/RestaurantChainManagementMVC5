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
    public class SaleMap : EntityTypeConfiguration<Sale>
    {
        public SaleMap()
        {
            ToTable(@"Sale", @"dbo");

            HasKey(x => x.SId);

            Property(x => x.SId)
                .HasColumnName("SId")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.BId)
                .HasColumnName("BId")
                .HasColumnType("smallint")
                .IsRequired();

            Property(x => x.STId)
                .HasColumnName("STId")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.Date)
                .HasColumnName("Date")
                .HasColumnType("datetime")
                .IsRequired();

            Property(x => x.CTId)
                .HasColumnName("CTId")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.UId)
                .HasColumnName("UId")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.CId)
                .HasColumnName("CId")
                .HasColumnType("int")
                .IsOptional();

            Property(x => x.SaleNote)
                .HasColumnName("SaleNote")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsOptional();

            Property(x => x.IpAdress)
                .HasColumnName("IpAdress")
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsRequired();

            Property(x => x.IsEOD)
                .HasColumnName("IsEOD")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.EOD)
                .HasColumnName("EOD")
                .HasColumnType("date")
                .IsOptional();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();

            

        }
    }
}
