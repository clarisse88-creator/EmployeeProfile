namespace API.Entities
{
    public class EmployeeInformation
    {
        public Guid Id { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string gender { get; set; }
        public DateOnly DateofBirth { get; set; }
        public string Nationality { get; set; }
        public string nationalId { get; set; }
        public string maritalStatus { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string EmergencyPhone { get; set; }
        public string UnitId { get; set; }
        public string JobId { get; set; }
    }
}
