using SchoolTech.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity;
using SchoolTech.Models;
using SchoolTech.Data.Repository;
using SchoolTech.Data.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SchoolTechContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDBConnection")));
builder.Services.AddRazorPages();
// Registratie voor dependency injection van UnitOfWork
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddDefaultIdentity<Gebruiker>().AddEntityFrameworkStores<SchoolTechContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    //options.Password.RequireDigit = true;
    //options.Password.RequireLowercase = true;
    //options.Password.RequireNonAlphanumeric = false;
    //options.Password.RequireUppercase = true;
    //options.Password.RequiredLength = 8;
    //options.Password.RequiredUniqueChars = 1;

    // Lockout settings.
    //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
    //options.Lockout.MaxFailedAccessAttempts = 3;
    //options.Lockout.AllowedForNewUsers = true;
    // User settings.
    //options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz0123456789-._@+";
    //options.User.RequireUniqueEmail = false;
});

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

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();