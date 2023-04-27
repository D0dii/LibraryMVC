using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LibraryMVC.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<LibraryMVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryMVCContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<DbInitializer>();

var app = builder.Build();

var scoped = app.Services.CreateScope();
var seeder = scoped.ServiceProvider.GetRequiredService<DbInitializer>();
await seeder.Seed();

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
