using Microsoft.EntityFrameworkCore;
using phuclien_company.Data;
using phuclien_company.Interfaces;
using phuclien_company.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PlcDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Repositories
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
