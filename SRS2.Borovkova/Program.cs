using Microsoft.EntityFrameworkCore;
using SRS2.Borovkova.Data;
using System.Text;
using System.IO;

using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);
// Добавляем сессии


// Add services to the container.
builder.Services.AddRazorPages();
// Добавляем ApplicationDbContext с использованием строки подключения из appsettings.json
builder.Services.AddDbContext<DateBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
