namespace LogifyMVC.Models
{
    public class TimeEntry
    {
        public int Id { get; set;}

        public int EmployeeId { get; set;}
        public Employee? Employee { get; set; }

        public DateTime ClockIn { get; set;}
        public DateTime? BreakStart { get; set;}
        public DateTime? BreakEnd { get; set;}
        public DateTime? ClockOut { get; set;}
        public string? Notes { get; set;}
    }
}
