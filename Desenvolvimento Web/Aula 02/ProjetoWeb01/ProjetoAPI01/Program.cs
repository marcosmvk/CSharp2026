using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Text.Json.Serialization;
using ProjetoAPI01.Classes.Repositorio;
using ProjetoAPI01.Classes.DTO;




var builder = WebApplication.CreateSlimBuilder(args);
var stringConexaoBancoAluno = builder.Configuration.GetConnectionString("Aluno") ?? throw new InvalidOperationException("A string de conexão 'Aluno' não foi encontrada no appsettings.json");

//Adicionar serviços a api
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

builder.Services.AddScoped(_ => new RepositorioUsuario(stringConexaoBancoAluno));


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
var gruposUsuarios = app.MapGroup("/api/usuarios");

gruposUsuarios.MapGet("/ping", () => Results.Ok(new { status = "ok" }));

//Endpoint REST responsável por autenticar o usuário
gruposUsuarios.MapPost("/login", async Task<IResult> (
    [FromBody] LoginRequestDTO dadosLogin,
    RepositorioUsuario repositorioUsuario,
    IWebHostEnvironment ambiente,
    ILogger<Program> logger,
    CancellationToken cancellationToken) =>
{
    if (string.IsNullOrWhiteSpace(dadosLogin.Email) || string.IsNullOrWhiteSpace(dadosLogin.Senha))
    {
        return Results.BadRequest(new LoginResponseDTO
        {
            Sucesso = false,
            Mensagem = "E-mail e senha são obrigatórios."
        });
    }
    try
    {
        using var timeoutCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        timeoutCts.CancelAfter(TimeSpan.FromSeconds(10));

        var usuario = await repositorioUsuario.BuscarPorEmailesenha(
            dadosLogin.Email, dadosLogin.Senha, timeoutCts.Token);

        if (usuario is null)
        {
            return Results.Json(new LoginResponseDTO
            {
                Sucesso = false,
                Mensagem = "E-mail ou senha inválidos."
            }, statusCode: StatusCodes.Status401Unauthorized);
        }

        return Results.Ok(new LoginResponseDTO
        {
            Sucesso = true,
            Mensagem = "Login realizado com sucesso",
            Nome = usuario.Nome,
            Regra = usuario.Regra
        });
    }
    catch (OperationCanceledException ex) when (!cancellationToken.IsCancellationRequested)
    {
        logger.LogError(ex, "Timeout ao autenticar usuário {Email}", dadosLogin.Email);
        return Results.Problem(
            title: "Timeout ao consultar o banco",
            detail: "A consulta demorou mais do que o esperado.",
            statusCode: StatusCodes.Status504GatewayTimeout);
    }
    catch (SqlException ex)
    {
        logger.LogError(ex, "Erro de banco ao tentar autenticar usuário {Email}", dadosLogin.Email);
        return Results.Problem(
            title: "Erro de acesso ao banco de dados",
            detail: ambiente.IsDevelopment() ? ex.Message : null,
            statusCode: StatusCodes.Status500InternalServerError);
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "Erro inesperado ao tentar autenticar usuário {Email}", dadosLogin.Email);
        return Results.Problem(
            title: "Erro inesperado ao processar login",
            detail: ambiente.IsDevelopment() ? ex.Message : null,
            statusCode: StatusCodes.Status500InternalServerError);
    }

}).WithName("LoginUsuario");

app.Run();

[JsonSerializable(typeof(LoginRequestDTO))]
[JsonSerializable(typeof(LoginResponseDTO))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{

}
