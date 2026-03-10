namespace LogifyMVC.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public List<TimeEntry> TimeEntries { get; set; } = new();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
