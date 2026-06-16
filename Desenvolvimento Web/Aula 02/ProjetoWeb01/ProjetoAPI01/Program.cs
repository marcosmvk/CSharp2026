using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using ProjetoAPI01.Classes.Repositorio;
using ProjetoAPI01.Classes.DTO;





var builder = WebApplication.CreateBuilder(args);

var stringConexaoBancoAluno = builder.Configuration.GetConnectionString("Aluno") ?? throw new InvalidOperationException(" A string de conexão 'Aluno' não foi encontrada no appsettings.json");

//Adicionar serviços a api
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

builder.Services.AddScoped(_ => RepositorioUsuario(stringConexaoBancoAluno));

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

var gruposUsuarios = app.MapGroup("/api/ususarios");

//Endpoint REST responsável por autenticar o usuário 
gruposUsuarios.MapPost("/login", async Task<IResult> ([FromBody] LoginRequestDTO dadoslogin, RepositorioUsuario repositoriousuario, CancellationToken cancellationToken) =>

{
if (string.IsNullOrWhiteSpace(dadoslogin.Email) || string.IsNullOrWhiteSpace(dadoslogin.Senha))

{
    return Results.BadRequest(new LoginResponseDTO
    {
        Sucesso = false,
        Mensagem = "E-mail e senha são obrigatórios."
    });
}
var usuario = await repositoriousuario.BuscarPorEmailesenha(dadoslogin.Email, dadoslogin.Senha, cancellationToken);
if (usuario is null)
{
    return Results.Unauthorized();
}

return Results.Ok(new LoginResponseDTO
{
    Sucesso = true,
        Mensagem = "Login realizado com sucess",
        Nome = usuario.Nome,
        Regra = usuario.Regra
    });

}).WithName("LoginUsuario");


app.Run();

[JsonSerializable(typeof(LoginRequestDTO))]
[JsonSerializable(typeof(LoginResponseDTO))]

internal partial class AppJsonSerializerContext : JsonSerializerContext
{

}
