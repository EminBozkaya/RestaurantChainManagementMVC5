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
    public class SaleNoteMap : EntityTypeConfiguration<SaleNote>
    {
        public SaleNoteMap()
        {
            ToTable(@"SaleNote", @"dbo");

            HasKey(x => x.NoteId);

            Property(x => x.NoteId)
                .HasColumnName("NoteId")
                .HasColumnType("tinyint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Definition)
                .HasColumnName("Definition")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsOptional();

            

        }
    }
}
