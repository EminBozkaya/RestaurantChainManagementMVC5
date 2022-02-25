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
    public class SaleNoteOfProductMap : EntityTypeConfiguration<SaleNoteOfProduct>
    {
        public SaleNoteOfProductMap()
        {
            ToTable(@"SaleNoteOfProduct", @"dbo");

            HasKey(x => x.PId);

            Property(x => x.PId)
                .HasColumnName("PId")
                .HasColumnType("smallint")
                .IsRequired();

            HasKey(x => x.NoteId);

            Property(x => x.NoteId)
                .HasColumnName("NoteId")
                .HasColumnType("tinyint")
                .IsRequired();

            Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();

        }
    }
}
