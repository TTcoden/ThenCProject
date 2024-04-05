// Início conexão com o banco de dados   
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics.Metrics;
using ThenC.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

string stringDeConexao = builder.Configuration.GetConnectionString("conexaoMySQL");
builder.Services.AddDbContext<BaseContext>(x => x.UseSqlServer(stringDeConexao));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
