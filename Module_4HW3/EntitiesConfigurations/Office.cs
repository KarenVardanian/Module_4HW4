using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4HW3.EntitiesConfigurations
{
    public class OfficeConfigurations : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(p => p.OfficeId);
            builder.Property(p => p.OfficeId).HasColumnName("Office").ValueGeneratedOnAdd();
            builder.HasData(new List<Office>(){
                new Office() { OfficeId = 1, Location = "Kiev", Title = "First" },
            new Office() { OfficeId = 2, Location = "Kherson", Title = "Fisecond" },
            new Office() { OfficeId = 3, Location = "Poltava", Title = "Third" } }   );
            builder.Property(p => p.Title).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Location).IsRequired().HasMaxLength(50);

        }

    }
}
