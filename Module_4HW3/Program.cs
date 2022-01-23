using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Module_4HW3.ServerSettings;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Module_4HW3
{
    public class SampleContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            var connectionString = "Server=DESKTOP-3OAE4IJ\\SQLEXPRESS;Database=Firt2;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
            return new ApplicationContext(optionsBuilder.Options);
        }


    }
    internal class Program
    {
        static  void Main(string[] args)
        {
           
            var path = new ServerSettings.Path();
            var a=path.GetPath("Config.json");
            var optionBuilde = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionBuilde.UseSqlServer(a).Options;
            using (ApplicationContext context = new ApplicationContext(options))
            {
                

            }
          
        }
    }
}
