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
    public class EmployeeRollCallMap : EntityTypeConfiguration<EmployeeRollCall>
    {
        public EmployeeRollCallMap()
        {
            ToTable(@"EmployeeRollCall", @"dbo");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.BId)
                .HasColumnName("BId")
                .HasColumnType("smallint")
                .IsRequired();

            Property(x => x.UId)
                .HasColumnName("UId")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.RollCaledEId)
                .HasColumnName("RollCaledEId")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.RCTId)
                .HasColumnName("RCTId")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.Date)
                .HasColumnName("Date")
                .HasColumnType("date")
                .IsRequired();

            Property(x => x.Note)
                .HasColumnName("Note")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsOptional();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.IsEOD)
                .HasColumnName("IsEOD")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.EOD)
                .HasColumnName("EOD")
                .HasColumnType("date")
                .IsOptional();

            Property(x => x.IpAdress)
                .HasColumnName("IpAdress")
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsRequired();
            
        }
    }
}
