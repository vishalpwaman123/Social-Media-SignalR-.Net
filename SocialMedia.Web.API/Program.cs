using Microsoft.EntityFrameworkCore;
using SocialMedia.Model.Context;
using SocialMedia.Repository;
using SocialMedia.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Dependency Injection

builder.Services.AddScoped<IAuthRepository, AuthRepository>();

#endregion

#region Database Dependency

builder.Services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnectionStrings")));

#endregion

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
