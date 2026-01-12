namespace API.Entities
{
    public class EmployeeCertificate
    {
        public Guid Id { get; set; }    
        public string TrainingId { get; set; } 
        public string EmployeeId { get; set; }
        public DateTime DateObtained { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}
