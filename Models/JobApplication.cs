namespace Project.Models
{
    public class JobApplication
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public Job? Job { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string ApplicantName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string CVPath { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
        public DateTime AppliedDate { get; set; } = DateTime.Now;
    }
}
