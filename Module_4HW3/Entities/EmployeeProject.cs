using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4Hw3.Entities
{
    public class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }
        public double Rate { get; set; }
        public DateTime StartDate { get; set; }

        public int IdEmployee { get; set; }
        public Employee Employee { get; set; }
        public int IdProject { get; set; }
        public Project Project { get; set; }

        public Title Title { get; set; }
        public int idTitle { get; set; }
        public Office Offices { get; set; }
        public int IdOffice { get; set; }
    }
}
