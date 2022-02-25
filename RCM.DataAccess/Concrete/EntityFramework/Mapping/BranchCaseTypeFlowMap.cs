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
    public class BranchCaseTypeFlowMap : EntityTypeConfiguration<BranchCaseTypeFlow>
    {
        public BranchCaseTypeFlowMap()
        {
            ToTable(@"BranchCaseTypeFlow", @"dbo");

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

            Property(x => x.CTId)
                .HasColumnName("CTId")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.Input)
                .HasColumnName("Input")
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .IsOptional();

            Property(x => x.Output)
                .HasColumnName("Output")
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .IsOptional();

            Property(x => x.Date)
                .HasColumnName("Date")
                .HasColumnType("smalldatetime")
                .IsRequired();

            Property(x => x.Note)
                .HasColumnName("Note")
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
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


