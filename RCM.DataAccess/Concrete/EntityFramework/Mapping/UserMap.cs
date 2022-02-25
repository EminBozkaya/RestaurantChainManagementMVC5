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
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable(@"User", @"dbo");

            HasKey(x => x.UId);

            Property(x => x.UId)
                .HasColumnName("UId")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                        
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

            Property(x => x.UserName)
                .HasColumnName("UserName")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Phone)
                .HasColumnName("Phone")
                .HasColumnType("char")
                .HasMaxLength(10)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();
                        
            Property(x => x.Password)
                .HasColumnName("Password")
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsRequired();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();

            Property(x => x.CreatedTime)
                .HasColumnName("CreatedTime")
                .HasColumnType("date")
                .IsOptional();

            Property(x => x.ModifiedTime)
                .HasColumnName("ModifiedTime")
                .HasColumnType("date")
                .IsOptional();

        }

    }
}
