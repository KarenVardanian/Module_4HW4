using Microsoft.EntityFrameworkCore;
using Module4Hw3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4HW3
{
    public class LINQ
    {
        private readonly ApplicationContext _context;

        public LINQ(ApplicationContext context)
        {
            _context = context;
        }
        public async Task LeftJoin()
        {
            var data = await _context.Projects.Include(x => x.EmployeeProjects).ThenInclude(c => c.Employee).ToListAsync();
        }  
        public async Task CountTimeDiffernce()
        {
            var employee = await _context.Projects.ToListAsync();
            foreach (var product in employee)
            {
                 TimeSpan timeSpan = DateTime.Now-product.StartedDate;
                 Console.WriteLine(timeSpan);
            }

        }
        public async Task GroupByRole()
        {
            //var role= await _context.Employees.OrderBy(_context.Employees.ToListAs)
        }
        public async Task DeleteDB()
        {
            var product = await _context.Projects.ToListAsync();
            var e= product.First(x => x.Id == 1);
            _context.RemoveRange(e);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateDB()
        {
            var product = await _context.Projects.FirstOrDefaultAsync(x => x.Id == 2);
            product.Budget = 1;
            await Task.Delay(TimeSpan.FromSeconds(5));
            await _context.SaveChangesAsync();
        }
        public async Task AddToDB()
        {
            using (var transction= _context.Database.BeginTransaction())
            {
                var employee = new Employee()
                {
                    DateOfBirth = DateTime.Now,
                    FirstName = "Test",
                    HiredDate = DateTime.Now,
                    LastName = "Test2",
                    OfficeId = 1,
                };
                _context.Clients.Add(new Entities.CLients()
                {
                    Age = 1,
                    LastName = "a",
                    Name = "Test",
                    Phone = "2193"
                });
                await _context.Employees.AddAsync(employee);
                await Task.Delay(TimeSpan.FromSeconds(10));
                await _context.SaveChangesAsync();
                await transction.CommitAsync();

            }
        }
    }
}
