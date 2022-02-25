using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using RCM.Model.Domain;

namespace RCM.DataAccess.Concrete.EntityFramework.Mapping
{
    public class AdressOfCustomerMap : EntityTypeConfiguration<AdressOfCustomer>
    {
        public AdressOfCustomerMap()
        {
            ToTable(@"AdressOfCustomer", @"dbo");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CId)
                .HasColumnName("CId")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.AdressName)
                .HasColumnName("AdressName")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsOptional();

            Property(x => x.Adress)
                .HasColumnName("Adress")
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsOptional();

        }
        
    }
}
