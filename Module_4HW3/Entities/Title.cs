using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4Hw3.Entities
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Names { get; set; }
        public List<Employee> Projects { get; set; } = new List<Employee>();
    }
}
