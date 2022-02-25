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
    public class SupplierMap : EntityTypeConfiguration<Supplier>
    {
        public SupplierMap()
        {
            ToTable(@"Supplier", @"dbo");

            HasKey(x => x.SpId);

            Property(x => x.SpId)
                .HasColumnName("SpId")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.BId)
                .HasColumnName("BId")
                .HasColumnType("smallint")
                .IsRequired();

            Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.FTId)
                .HasColumnName("FTId")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.CurrentDept)
                .HasColumnName("CurrentDept")
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .IsOptional();

            Property(x => x.Adress)
                .HasColumnName("Adress")
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsOptional();

            Property(x => x.CompanyName)
                .HasColumnName("CompanyName")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsOptional();

            Property(x => x.Phone)
                .HasColumnName("Phone")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsOptional();

            Property(x => x.Note)
                .HasColumnName("Note")
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsOptional();

            Property(x => x.ModifiedBy)
                .HasColumnName("ModifiedBy")
                .HasColumnType("int")
                .IsOptional();

            Property(x => x.ModifiedTime)
                .HasColumnName("ModifiedTime")
                .HasColumnType("smalldatetime")
                .IsOptional();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();
            
            

        }
    }
}
