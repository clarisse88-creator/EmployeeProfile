namespace API.Entities
{
    public class EmployeeReferees
    {
        public  Guid  Id  {  get;  set; }
        public string EmployeeId { get; set; }
        public string RefereeName { get; set; }
        public string Phone { get; set; }   
        public string Email { get; set; }
        public string Relationship { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

    }
}
