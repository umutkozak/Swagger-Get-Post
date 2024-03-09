using Microsoft.EntityFrameworkCore;
using Swagger.Core.Abstraction;
using Swagger.Core.Concrate;
using Swagger.DataAccess.Context;
using Swagger.Entity;
using Swager.Services.AutoMapper.Employees;
using Swager.Services.Services.Abstraction;
using Swager.Services.Services.Concrate;
using Swagger.DTO_s.EmployeeDtos;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IRepository<Employee>,Repository<Employee>>();
builder.Services.AddScoped<IEmployeeService,EmployeeService>();
builder.Services.AddAutoMapper(typeof(EmployeeProfile),typeof(EmployeeAddDTO));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title= "Northwind API",
        Version= "v1",
        Description="Example",
        Contact=new Microsoft.OpenApi.Models.OpenApiContact()
        {
            Email="umutkozak@bilgeadam.com",
            Name="Umut Kozak",
            Url=new Uri("https://www.bilgeadam.com")
        },
        License=new Microsoft.OpenApi.Models.OpenApiLicense()
        {
            Name="Ba Lisence",
            Url=new Uri("https://www.bilgeadam.com")
        }
    }
    );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseAuthorization();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options =>
    {
        options.SerializeAsV2 = true;
    });
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        //options.RoutePrefix = string.Empty;
    });
}



app.MapControllers();

app.Run();
