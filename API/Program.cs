using Microsoft.EntityFrameworkCore;
using Infrastructure;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StoreContext>(x =>
{
    x.UseSqlite(builder.Configuration["ConnectionStrings:DefaultConnection"]);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();
var servicesScopeProvider = scope.ServiceProvider;

var logger = servicesScopeProvider.GetRequiredService<ILogger<Program>>();

try
{
    var context = servicesScopeProvider.GetRequiredService<StoreContext>();
    context.Database.Migrate();
    await StoreContextSeed.SeedAsync(context, logger);
}
catch (Exception ex)
{
    logger.LogError(ex, "Something happened during migration");

    throw;
}


app.Run();
