using BlazorApp11.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// Configuraci�n de la conexi�n a la base de datos
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

// Verificaci�n de la conexi�n a la base de datos
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    try
    {
        // Intentar realizar una consulta simple para verificar la conexi�n
        var canConnect = dbContext.Database.CanConnect();  // Verifica si la conexi�n a la base de datos es posible
        if (canConnect)
        {
            Console.WriteLine("Conexi�n exitosa a la base de datos.");
        }
        else
        {
            Console.WriteLine("No se pudo conectar a la base de datos.");
        }
    }
    catch (Exception ex)
    {
        // Si ocurre un error de conexi�n, lo capturamos
        Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
    }
}

// Configuraci�n del flujo de trabajo habitual
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
