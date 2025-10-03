using Macchiato.Application.Abstractions;
using Macchiato.Application.Commands.Servers;
using Macchiato.Infrastructure;
using Mediator.Net;
using Mediator.Net.MicrosoftDependencyInjection;

namespace Macchiato.Server;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.AddServiceDefaults();

        var mediaBuilder = new MediatorBuilder();
        var mediator = mediaBuilder.RegisterHandlers(typeof(CreateCommand).Assembly).Build();

        builder.Services.RegisterMediator(mediaBuilder);
        builder.Services.AddScoped<IServerRepository, ServerRepository>();
        builder.Services.AddAutoMapper(P =>
        {
            P.AddProfile<MappingProfile>();
        });

        Directory.CreateDirectory("Servers");

        builder.Services.AddDistributedMemoryCache();

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.MapDefaultEndpoints();

        app.UseDefaultFiles();
        app.UseStaticFiles();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.MapFallbackToFile("/index.html");

        app.Run();
    }
}
