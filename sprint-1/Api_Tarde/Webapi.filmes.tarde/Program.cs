using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//adiciona os servicos de controles
builder.Services.AddControllers();
//Adicione o gerador do Swagger à coleção de serviços no
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API FILMES_TARDE",
        Description = "Api para gerenciamento de filmes - Introducao a sprint 2 - Backend API",
        Contact = new OpenApiContact
        {
            Name = "Guilherme Alberto",
            Url = new Uri("https://github.com/guihenrique16")
        },
    });

    //Configure o Swagger para usar o arquivo XML
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

//Habilite o middleware para atender ao documento JSON gerado e à interface do usuário do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Para atender à interface do usuário do Swagger na raiz do aplicativo 
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

//mapear os controles
app.MapControllers();

app.Run();
