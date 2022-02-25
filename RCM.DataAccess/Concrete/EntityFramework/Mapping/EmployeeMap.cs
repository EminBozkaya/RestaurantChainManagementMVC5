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
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable(@"Employee", @"dbo");

            HasKey(x => x.EId);

            Property(x => x.EId)
                .HasColumnName("EId")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.BId)
                .HasColumnName("BId")
                .HasColumnType("smallint")
                .IsRequired();

            Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.LastName)
                .HasColumnName("LastName")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.PositionId)
                .HasColumnName("PositionId")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.WorkTypeId)
                .HasColumnName("WorkTypeId")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.SalaryTypeId)
                .HasColumnName("SalaryTypeId")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.Fee)
                .HasColumnName("Fee")
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .IsRequired();

            Property(x => x.Phone)
                .HasColumnName("Phone")
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            Property(x => x.SecondaryPhone)
                .HasColumnName("SecondaryPhone")
                .HasColumnType("char")
                .HasMaxLength(11)
                .IsFixedLength()
                .IsUnicode(false)
                .IsOptional();

            Property(x => x.Adress)
                .HasColumnName("Adress")
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsOptional();

            Property(x => x.Mail)
                .HasColumnName("Mail")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsOptional();

            Property(x => x.BirthDate)
                .HasColumnName("BirthDate")
                .HasColumnType("date")
                .IsOptional();

            Property(x => x.Gender)
                .HasColumnName("Gender")
                .HasColumnType("char")
                .HasMaxLength(1)
                .IsFixedLength()
                .IsUnicode(false)
                .IsOptional();

            Property(x => x.HireDate)
                .HasColumnName("HireDate")
                .HasColumnType("date")
                .IsRequired();

            Property(x => x.FireDate)
                .HasColumnName("FireDate")
                .HasColumnType("date")
                .IsOptional();

            Property(x => x.Note)
                .HasColumnName("Note")
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsOptional();
                        
            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();

            

        }
    }
}
