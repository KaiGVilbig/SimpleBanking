using MediatR;
using Banking.Application.Commands; // where your commands & handlers live

var builder = WebApplication.CreateBuilder(args);

// Register MediatR: scan all assemblies that contain handlers
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblyContaining<OpenAccountCommand>();
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
