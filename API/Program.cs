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
app.MapGet("/GetEmployeeLanguage", () =>
{
    DataContext context = new DataContext();
    var EmployeeLanguage = context.Set<EmployeeLanguage>().ToList();
    return Results.Ok(EmployeeLanguage);

});
app.Run();
