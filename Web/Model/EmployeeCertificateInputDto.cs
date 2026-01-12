namespace Web.Model
{
    public class EmployeeCertificateInputDto
    {
        public string TrainingId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime DateObtained { get; set; }
        public string CreatedBy { get; set; }
    }
}
