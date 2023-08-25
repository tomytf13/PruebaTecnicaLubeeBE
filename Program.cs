using APIColegio.Managers;
using APIColegio.Managers.Interfaces;
using APIColegio.Repositories;
using APIColegio.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Setup dependencies injection
builder.Services.AddTransient<ISupportManager,SupportManager>();
builder.Services.AddScoped<IPedidosRepository,PedidosRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
