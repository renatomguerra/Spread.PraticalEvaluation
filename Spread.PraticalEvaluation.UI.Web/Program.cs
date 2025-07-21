using Spread.PraticalEvaluation.Infra.Ioc;
using Spread.PraticalEvaluation.UI.Web.Mappings;
using AutoMapper;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(ConfigurationMapping)));
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "create",
    pattern: "{controller}/{action=Create}");

app.MapControllerRoute(
    name: "edit",
    pattern: "{controller}/{action=Edit}/{id}");

app.MapControllerRoute(
    name: "delete",    
    pattern: "{controller}/{action=Delete}/{id}");

app.Run();
