using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Infra.IoC;
using MVC.MappingConfig;

var builder = WebApplication.CreateBuilder(args);

// Adicione os serviços ao container.
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddAutoMapperConfiguration();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure o pipeline de requisições HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
