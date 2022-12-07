using PatientMovementManagement.Application;
using PatientMovementManagement.Infrastructure;
using PatientMovementManagement.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddPresistance(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddCors(opt =>
opt.AddPolicy(name: "MyAllowSpecificOrgins",
builder =>
{
    builder.WithOrigins("http://localhost:3000")
                  .AllowAnyMethod()
                  .AllowAnyHeader();
                  //.AllowCredentials()
                  //.SetPreflightMaxAge(TimeSpan.FromSeconds(2520));
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyAllowSpecificOrgins");

app.UseAuthorization();

app.MapControllers();

app.Run();
