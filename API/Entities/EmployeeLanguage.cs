namespace API.Entities
{
    public class EmployeeLanguage
    {
        public Guid Id { get; set; }
        public string EmployeeId { get; set; }
        public string LanguageName { get; set; }
        public string ProficiencyLevel { get; set; }
        public string Writing { get; set; }
        public string Reading { get; set; }
        public string Speaking { get; set; }
        public DateTime CreatedAt { get; set; } 
        public string CreatedBy { get; set; }
    }
}
