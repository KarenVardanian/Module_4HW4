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
    public class EmloyeeCongigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(p => p.EmployeeId);
            builder.Property(p => p.EmployeeId).HasColumnName("Employee").ValueGeneratedOnAdd();
            builder.Property(p=>p.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(p=>p.LastName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.HiredDate).IsRequired().HasMaxLength(7);
        }
    }
}
