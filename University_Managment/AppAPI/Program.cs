using BLL.Services;
using DAL;
using DAL.EF;
using DAL.EF.Model;
using DAL.EF.Repos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<DepertmentRepo>();
builder.Services.AddScoped<DepertmentService>();

builder.Services.AddScoped<StudentRepo>();
builder.Services.AddScoped<StudentService>();

builder.Services.AddScoped<CourseRepo>();
builder.Services.AddScoped<CourseService>();

builder.Services.AddScoped<PaymentRepo>();
builder.Services.AddScoped<PaymentService>();

builder.Services.AddScoped<CheckDetailService>();

builder.Services.AddDbContext<UMSContaxt>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConn")));

builder.Services.AddScoped<DataAccessFactory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
