using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module_4HW3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4HW3.EntitiesConfigurations
{
    public class ClientConfigurations : IEntityTypeConfiguration<CLients>
    {
        public void Configure(EntityTypeBuilder<CLients> builder)
        {
            builder.ToTable("Clients").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Clients").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Age).IsRequired().HasMaxLength(3);
            builder.Property(p => p.Phone).IsRequired().HasMaxLength(12);
            builder.HasData(new List<CLients>(){
                new CLients(){ Id=1,Name="Client1", Age=25 , LastName="Petrov", Phone="380994832312" },
                new CLients(){Id=2, Name="Ivan", Age=53 , LastName="Sidorov", Phone="380664832312" },
                new CLients(){Id=3, Name="Petr", Age=36 , LastName="Begunenko", Phone="38099465312" },
                new CLients(){Id=4, Name="Stepan", Age=18 , LastName="Petenko", Phone="380955831312" },
                new CLients(){Id=6, Name="Stepan2", Age=18 , LastName="Petenko", Phone="380955831312" },
                new CLients(){Id=5, Name="Nikolay", Age=67 , LastName="Sidorenko", Phone="380974837862" } }
                );

        }
    }
}
