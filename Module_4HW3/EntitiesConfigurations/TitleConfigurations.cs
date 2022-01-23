using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4Hw3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4HW3.EntitiesConfigurations
{
    public class TitleConfigurations : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(p=>p.TitleId);
            builder.Property(p=>p.TitleId).HasColumnName("Title").ValueGeneratedOnAdd();
            builder.Property(p => p.Names).IsRequired().HasMaxLength(50);

        }
    }
}
