namespace API.Entities
{
    public class EducationLevel
    {
        public Guid Id { get; set; }
        public string employeeId { get; set; }
        public string Institution { get; set; }
        public string Qualification { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime EndYear { get; set; }
        public DateTime CreatDate { get; set; }
    }
}
