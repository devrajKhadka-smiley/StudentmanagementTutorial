using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentManagementSystem.Database;
using StudentManagementSystem.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//---------for IOptions
builder.Services.Configure<AI>(
    builder.Configuration.GetSection("UsedAi")
    );

builder.Services.AddDbContext<StudentDbContext>(
    (OptionsBuilder) =>
    {
        OptionsBuilder.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"));
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


