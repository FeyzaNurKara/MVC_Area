using Microsoft.EntityFrameworkCore;
using MVC_Area.Models.Northwind;
using MVC_Area.Repositories.Abstracts;
using MVC_Area.Repositories.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connectionString = builder.Configuration.GetConnectionString("FeyzaConnection");
//AddDbcontext
builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(connectionString));

//Dependency Injection Services

//Satýn alma Ýþlemleri
builder.Services.AddScoped<IProductRepository,ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();



//Muhasebe Ýþlemleri
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped <IOrdersDetailsRepository, OrdersDetailsRepository >();



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

#region Routes


//Area Route
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


//Default Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); 

#endregion

app.Run();
