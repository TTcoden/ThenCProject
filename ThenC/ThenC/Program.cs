using Microsoft.EntityFrameworkCore;
using ThenC.Repository.Person;
using ThenC.Data;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//string connectionString = builder.Configuration.GetConnectionString("conexaoMySQL");
//builder.Services.AddDbContext<BaseContext>(x => x.UseSqlServer(connectionString));

var connectionString = builder.Configuration.GetConnectionString("conexaoMySQL");
builder.Services.AddDbContext<BaseContext>(x => x.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
//Injetando dependencia da Interface resolvendo ela com uma classe
builder.Services.AddScoped<ITablesRepository, TablesRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
//teste

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
