using FoundItBE_Users.BusinessLayer;
using FoundItBE_Users.Domain;
using FoundItBE_Users.Infrastructure;
using FoundItBE_Users.Infrastructure.Options;
using FoundItBE_Users.Validation;
using Microsoft.Extensions.Caching.Memory;

namespace FoundItBE_Users.ServiceHost;

public class Startup
{
    public IConfiguration Configuration { get; }
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddMvc();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.Configure<PostGresqlConnectionOptions>(Configuration.GetSection(PostGresqlConnectionOptions.PostGresqlOptionsKey));
        services.AddSingleton<IMemoryCache>();

        services.AddInfrastructure();
        services.AddBusinessLayer();
        services.AddDomainLayer();
        services.AddValidation();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.UseStaticFiles();
    }
}
