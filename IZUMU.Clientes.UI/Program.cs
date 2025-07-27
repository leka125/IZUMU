using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Inyección de dependencias para Infrastructure
builder.Services.AddDbContext<IZUMU.Clientes.Infrastructure.DatosPersonalesDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IZUMU.Clientes.Infrastructure.Repositories.DatosPersonalesRepository>();
builder.Services.AddScoped<IZUMU.Clientes.UI.Servicios.DatosPersonalesService>();

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
    pattern: "{controller=DatosPersonales}/{action=Index}/{id?}");

app.Run();
