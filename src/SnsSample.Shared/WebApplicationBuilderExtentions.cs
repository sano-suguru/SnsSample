using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SnsSample.Shared.Options;

namespace SnsSample.Shared;
public static class WebApplicationBuilderExtentions
{
    public static void AddSharedSettings(this WebApplicationBuilder builder)
    {
        IHostEnvironment env = builder.Environment;
        ConfigurationManager config = builder.Configuration;
        IServiceCollection services = builder.Services;

        var sharedFolder = Path.Combine(env.ContentRootPath, "..", "SnsSample.Shared");

        config.AddJsonFile(Path.Combine(sharedFolder, "sharedsettings.json"), optional: true);
        config.AddJsonFile(Path.Combine(sharedFolder, $"sharedsettings.{env.EnvironmentName}.json"), optional: true);
        config.AddJsonFile("sharedsettings.json", optional: true); // publishされた際に参照
        config.AddJsonFile($"sharedsettings.{env.EnvironmentName}.json", optional: true);
        config.AddJsonFile("appsettings.json", optional: true); // publishされた際に参照
        config.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

        //usage: Referencing IOptions<MyTestOptions> with dependency injection
        services.AddOptions<MyTestOptions>().Bind(config.GetSection(MyTestOptions.SectionName));
    }
}
