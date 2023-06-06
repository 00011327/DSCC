using LibraryUI.Models;
using LibraryUI.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var settings = builder.Configuration.GetSection("ConnectionStrings").Get<Settings>();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BooksContext>(
                options => options.UseSqlServer(settings.DefaultConnection));



builder.Services.AddScoped<IRepository<Book>, BookRepository>();
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
    pattern: "{controller=Books}/{action=Index}/{id?}");

app.Run();
