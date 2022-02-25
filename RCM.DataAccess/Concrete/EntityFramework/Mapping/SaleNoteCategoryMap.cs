using RCM.Model.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RCM.DataAccess.Concrete.EntityFramework.Mapping
{
    public class SaleNoteCategoryMap : EntityTypeConfiguration<SaleNoteCategory>
    {
        public SaleNoteCategoryMap()
        {
            ToTable(@"SaleNoteCategory", @"dbo");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("tinyint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.NotCat)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
