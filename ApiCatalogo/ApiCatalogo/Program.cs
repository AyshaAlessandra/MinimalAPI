using ApiCatalogo.ApiEndpoints;
using ApiCatalogo.AppServicesExtensions;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.AddApiSwagger();
        builder.AddPersistence();
        builder.Services.AddCors();
        builder.AddAuteticationJWT();

        var app = builder.Build();

        //definir os endpoints depois de dar o build.
        app.MapAutenticacaoEndpoints();
        app.MapCategoriasEndpoints();
        app.MapProdutosEndpoints();

        // Configure the HTTP request pipeline.

        var environment = app.Environment;
        app.UseExceptionHandling(environment)
            .UseSwaggerMiddleware()
            .UseAppCors();

        app.UseAuthentication();
        app.UseAuthorization();

        app.Run();
    }
}