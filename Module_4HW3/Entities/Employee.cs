using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4Hw3.Entities
{
    public class Employee
    {
       public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName {  get; set;}
        public DateTime HiredDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
        public int OfficeId { get; set; }

        public List<Title> Titles { get; set; } = new List<Title>();
        public List<Office> Offices { get; set; } = new List<Office>();
    }
}
