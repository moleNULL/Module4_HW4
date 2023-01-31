namespace EFCore_CodeFirst.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartedTime { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
