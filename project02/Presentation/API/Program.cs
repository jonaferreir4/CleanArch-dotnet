using Application.Services;
using Repositories;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;


var builder = WebApplication.CreateBuilder(args);


builder.Services.ConfigurePersistenceApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


static void CreateDatabase(WebApplication app)
{
    using (var scope = app.Services.CreateScope()) 
    {
        var services = scope.ServiceProvider;
        try
        {
            var context = services.GetRequiredService<AppDbContext>(); 
            context.Database.EnsureCreated();        
            
            }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>(); 
            logger.LogError(ex, "Ocorreu um erro ao criar o banco de dados.");
        }
    }
}

CreateDatabase(app);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.Run();
