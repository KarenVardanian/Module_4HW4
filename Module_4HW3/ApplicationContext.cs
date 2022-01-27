using Microsoft.EntityFrameworkCore;
using Module_4HW3.Entities;
using Module_4HW3.EntitiesConfigurations;
using Module4Hw3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4HW3
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
      public  DbSet<Office> Offices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Title> Titles { get; set; }
       public DbSet<EmployeeProject> EmployeeProjects { get; set; }
       public DbSet<CLients> Clients { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
                //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmloyeeCongigurations());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfigurations());
            modelBuilder.ApplyConfiguration(new OfficeConfigurations());
            modelBuilder.ApplyConfiguration(new ProjectConfigurations());
            modelBuilder.ApplyConfiguration(new TitleConfigurations());
            modelBuilder.ApplyConfiguration(new ClientConfigurations());
        }
    }
}
