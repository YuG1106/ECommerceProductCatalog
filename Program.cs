using ECommerceProductCatalog.Data;       // For ApplicationDbContext
using Microsoft.EntityFrameworkCore;      // For UseSqlServer

var builder = WebApplication.CreateBuilder(args);

// ---------------------
// Add services
// ---------------------
builder.Services.AddControllersWithViews();

// Register the database context with SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ---------------------
// Build the app
// ---------------------
var app = builder.Build();

// ---------------------
// Configure the HTTP request pipeline
// ---------------------
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();   // For wwwroot (images, css, js)

app.UseRouting();

app.UseAuthorization();

// Default route: opens Home/Index or Products if you prefer
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// ---------------------
// Run the app
// ---------------------
app.Run();
