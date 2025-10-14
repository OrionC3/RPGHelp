using Microsoft.EntityFrameworkCore;
using WorkGroup_RPGHelp.BLL.Services;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DAL.Contexts;
using WorkGroup_RPGHelp.DAL.Repositories;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DbContext
// Add DB Context
builder.Services.AddDbContext<RPGHelpContext>(b =>
    b.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);
#endregion

builder.Services.AddScoped <IUserRepository, UserRepository>();
builder.Services.AddScoped <IUserService, UserService>();

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
