using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder Builder)
        {
            Builder.UseSqlServer("YourConnectionStringHere");
            Builder.UseSqlServer("Data Source=.; initial Catalog=EmployeeProfile; Integrated Security=True; TrustServerCertificate =true;");

        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.Entity<EducationLevel>();

            model.Entity<EmployeeExperience>();

            model.Entity<EmployeeLanguage>();
        }
    }
}
