namespace Project.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Qualification { get; set; } = string.Empty;
        public int Vacancies { get; set; }
        public DateTime LastDate { get; set; }
        public DateTime PostedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
