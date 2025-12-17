namespace Web.Model
{
    public class EmployeeExperienceGetDto
    {
        public Guid Id { get; set; }
        public string EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
