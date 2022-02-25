using RCM.Model.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RCM.DataAccess.Concrete.EntityFramework.Mapping
{
    public class MyExceptionMap : EntityTypeConfiguration<MyException>
    {
        public MyExceptionMap()
        {
            ToTable(@"MyException", @"dbo");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.UId)
                .HasColumnName("UId")
                .HasColumnType("int")
                .IsOptional();

            Property(x => x.Date)
                .HasColumnName("Date")
                .HasColumnType("smalldatetime")
                .IsOptional();

            Property(x => x.HResultCode)
                .HasColumnName("HResultCode")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsOptional();

            Property(x => x.Message)
                .HasColumnName("Message")
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                .IsOptional();

            Property(x => x.Source)
                .HasColumnName("Source")
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsOptional();

            Property(x => x.StackTrace)
                .HasColumnName("StackTrace")
                .HasColumnType("nvarchar")
                .HasMaxLength(4000)
                .IsOptional();

            Property(x => x.ParamName)
                .HasColumnName("ParamName")
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsOptional();

            Property(x => x.Errors)
                .HasColumnName("Errors")
                .HasColumnType("nvarchar")
                .HasMaxLength(4000)
                .IsOptional();

            Property(x => x.InnerMessage)
                .HasColumnName("InnerMessage")
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                .IsOptional();

            Property(x => x.InnerSource)
                .HasColumnName("InnerSource")
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsOptional();

            Property(x => x.InnerStackTrace)
                .HasColumnName("InnerStackTrace")
                .HasColumnType("nvarchar")
                .HasMaxLength(4000)
                .IsOptional();

            Property(x => x.InnerParamName)
                .HasColumnName("InnerParamName")
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsOptional();

            Property(x => x.InnerErrors)
                .HasColumnName("InnerErrors")
                .HasColumnType("nvarchar")
                .HasMaxLength(4000)
                .IsOptional();

        }
    }
}
