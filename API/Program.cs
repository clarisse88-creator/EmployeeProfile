using API.Entities;
using API.Model;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSwaggerGen();
builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", new CorsPolicy
{
    Origins = { "*" },
    Headers = { "*" },
    Methods = { "*" }
}));
var app = builder.Build();

app.UseCors("CorsPolicy");
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Welcome to EmployeeProfile");

app.MapPost("/SaveEducationLevel", (EducationInputDto std) =>
{
    DataContext context = new DataContext();
    var EducationLevel = new EducationLevel();
    EducationLevel.employeeId = std.employeeId;
    EducationLevel.Institution = std.Institution;
    EducationLevel.Qualification = std.Qualification;
    EducationLevel.StartYear = std.StartYear;
    EducationLevel.EndYear = std.EndYear;
    EducationLevel.CreatDate = DateTime.Now;
    context.Add(EducationLevel);
    context.SaveChanges();
    return Results.Ok("Save Succefully");
});
app.MapPost("/SaveEmployeeExperience", (EmployeeExperienceInputDto std) =>
{
    DataContext context = new DataContext();
    var EmployeeExperience = new EmployeeExperience();
    EmployeeExperience.EmployeeId = std.EmployeeId;
    EmployeeExperience.CompanyName = std.CompanyName;
    EmployeeExperience.Position = std.Position;
    EmployeeExperience.StartDate = std.EndDate;
    EmployeeExperience.EndDate = std.EndDate;
    EmployeeExperience.Description = std.Description;
    EmployeeExperience.CreatedBy = std.CreatedBy;
    context.Add(EmployeeExperience);
    context.SaveChanges();
    return Results.Ok("Save Succefully");
});
app.MapPost("/SaveEmployeeLanguage", (EmployeeLanguageInputDto std) =>
{
    DataContext context = new DataContext();
    var EmployeeLanguage = new EmployeeLanguage();
    EmployeeLanguage.EmployeeId = std.EmployeeId;
    EmployeeLanguage.LanguageName = std.LanguageName;
    EmployeeLanguage.ProficiencyLevel = std.ProficiencyLevel;
    EmployeeLanguage.Writing = std.Writing;
    EmployeeLanguage.Reading = std.Reading;
    EmployeeLanguage.Speaking = std.Speaking;
    EmployeeLanguage.CreatedBy = std.CreatedBy;
    context.Add(EmployeeLanguage);
    context.SaveChanges();
    return Results.Ok("Save Succefully");
});
app.MapPost("/SaveEmployeeReferees", (EmployeeRefereesInputDto std) =>
{
    DataContext context = new DataContext();
    var EmployeeReferees = new EmployeeReferees();
    EmployeeReferees.EmployeeId = std.EmployeeId;
    EmployeeReferees.RefereeName = std.RefereeName;
    EmployeeReferees.Phone = std.Phone;
    EmployeeReferees.Email = std.Email;
    EmployeeReferees.Relationship = std.Relationship;
    EmployeeReferees.Address = std.Address;
    EmployeeReferees.CreatedBy = std.CreatedBy;
    context.Add(EmployeeReferees);
    context.SaveChanges();
    return Results.Ok("Save Succefully");
});
app.MapPost("/SaveEmployeeCertificate", (EmployeeCertificateInputDto std) =>
{
    DataContext context = new DataContext();
    var EmployeeCertificate = new EmployeeCertificate();
    EmployeeCertificate.TrainingId = std.EmployeeId;
    EmployeeCertificate.EmployeeId = std.EmployeeId;
    EmployeeCertificate.DateObtained = std.DateObtained;
    EmployeeCertificate.CreatedBy = std.CreatedBy;
    EmployeeCertificate.DateCreated = DateTime.Now;
    context.Add(EmployeeCertificate);
    context.SaveChanges();
    return Results.Ok("Save Succefully");
});
app.MapPost("/SaveEmployeeInformation", (EmployeeInformationInputDto std) =>
{
    DataContext context = new DataContext();
    var EmployeeInformation = new EmployeeInformation();
    EmployeeInformation.EmployeeId = std.EmployeeId;
    EmployeeInformation.FirstName = std.FirstName;
    EmployeeInformation.LastName = std.LastName;
    EmployeeInformation.gender = std.gender;
    EmployeeInformation.DateofBirth = std.DateofBirth;
    EmployeeInformation.Nationality = std.Nationality;
    EmployeeInformation.nationalId = std.nationalId;
    EmployeeInformation.maritalStatus = std.maritalStatus;
    EmployeeInformation.Email = std.Email;
    EmployeeInformation.Address = std.Address;
    EmployeeInformation.EmergencyPhone = std.EmergencyPhone;
    EmployeeInformation.UnitId = std.UnitId;
    EmployeeInformation.JobId = std.JobId;
    context.Add(EmployeeInformation);
    context.SaveChanges();
    return Results.Ok("Save Succefully");
});

app.MapGet("/GetEducationLevel", () =>
{
    DataContext context = new DataContext();
    var EducationLevel = context.Set<EducationLevel>().ToList();
    return Results.Ok(EducationLevel);

});
app.MapGet("/GetEmployeeExperience", () =>
{
    DataContext context = new DataContext();
    var EmployeeExperience = context.Set<EmployeeExperience>().ToList();
    return Results.Ok(EmployeeExperience);

});
app.MapGet("/EmployeeLanguage", () =>
{
    DataContext context = new DataContext();
    var EmployeeLanguage = context.Set<EmployeeLanguage>().ToList();
    return Results.Ok(EmployeeLanguage);

});
app.MapGet("/GetEmployeeReferees", () =>
{
    DataContext context = new DataContext();
    var EmployeeReferees = context.Set<EmployeeReferees>().ToList();
    return Results.Ok(EmployeeReferees);

});

app.MapGet("/GetEmployeeCertificate", () =>
{
    DataContext context = new DataContext();
    var EmployeeCertificate = context.Set<EmployeeCertificate>().ToList();
    return Results.Ok(EmployeeCertificate);

});
app.MapGet("/GetEmployeeInformation", () =>
{
    DataContext context = new DataContext();
    var EmployeeInformation = context.Set<EmployeeInformation>().ToList();
    return Results.Ok(EmployeeInformation);

});
app.Run();
