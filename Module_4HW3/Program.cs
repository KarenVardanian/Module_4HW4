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
    public class Program
    {
        static async Task Main(string[] args)
        {
           
            await using (var context = new SampleContextFactory().CreateDbContext(args))
            {
                // await new LINQ(context).LeftJoin();
                // await new LINQ(context).CountTimeDiffernce();
                // await new LINQ(context).AddToDB();
                // await new LINQ(context).AddToDB();
                // await new LINQ(context).UpdateDB();
            }
        }
    }
}
