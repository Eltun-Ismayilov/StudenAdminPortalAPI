using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.BIZNES.Interface;
using StudentAdminPortal.BIZNES.Repositories;
using StudentAdminPortal.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors((options) =>
{
    options.AddPolicy("angularApplocation", (builder) =>
    {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .WithMethods("GET", "POST", "PUT", "DELETE")
        .WithExposedHeaders("*");
    });
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IStudentRepo, StudentRepo>();

var connectionString = builder.Configuration.GetConnectionString("cString");
builder.Services.AddDbContext<StudentAdminDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(StartupBase).Assembly);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseCors("angularApplocation");

app.UseAuthorization();

app.MapControllers();

app.Run();
