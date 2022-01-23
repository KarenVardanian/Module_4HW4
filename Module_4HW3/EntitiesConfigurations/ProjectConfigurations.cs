using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4HW3.EntitiesConfigurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Project").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.StartedDate).IsRequired().HasMaxLength(7);
            builder.Property(p => p.Id).IsRequired();

            builder.HasData(new List<Project>(){
                new Project(){ Name="First", StartedDate= DateTime.Now, Budget=12000, Term=21,Id=1, ClientsId=1 },
                new Project(){ Name="Second", StartedDate= DateTime.Now, Budget=14000, Term=30,Id=2,ClientsId=1 },
                new Project(){ Name="Third", StartedDate= DateTime.Now, Budget=20000, Term=50,Id=3,ClientsId=1 },
                new Project(){ Name="Fourth", StartedDate= DateTime.Now, Budget=30000, Term=14,Id=4,ClientsId=1 },
                new Project(){ Name="fifth", StartedDate= DateTime.Now, Budget=10000, Term=79,Id=5,ClientsId=2 } }
                );      
        }
    }
}
