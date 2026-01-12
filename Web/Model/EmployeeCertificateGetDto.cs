namespace Web.Model
{
    public class EmployeeCertificateGetDto
    {
        public Guid Id { get; set; }
        public string TrainingId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime DateObtained { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
    }
}
