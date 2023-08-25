var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

//mapear os controles
app.MapControllers();

app.Run();
