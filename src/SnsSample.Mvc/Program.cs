using System.Reflection;
using SnsSample.Infrastructure.Sqlite;
using SnsSample.Shared.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the containexr.
builder.Services.AddServicesInAssembly(Assembly.GetAssembly(typeof(Program))!);
builder.Services.AddSqliteRepositories(builder.Environment);
builder.Services.AddControllersWithViews();

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
    pattern: "mvc/{controller=Home}/{action=Index}/{id?}");

app.Run();
