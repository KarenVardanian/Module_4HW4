using Module_4HW3.Entities;
using Module4Hw3.Entities;
using System;
using System.Collections.Generic;

public class Project
{
	public int Id { get; set; }
	public string Name { get; set; }
	public double Budget { get; set; }
	public DateTime StartedDate { get; set; }
	public int Term { get; set; }
	public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    public CLients client { get; set; }
    public int ClientsId { get; set; }

}
