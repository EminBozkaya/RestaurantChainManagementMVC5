﻿using RCM.Model.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCM.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PositionTypeMap : EntityTypeConfiguration<PositionType>
    {
        public PositionTypeMap()
        {
            ToTable(@"PositionType", @"dbo");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("tinyint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Type)
                .HasColumnName("Type")
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .IsRequired();

           
        }
    }
}
