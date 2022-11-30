using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace SnsSample.Shared.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServicesInAssembly(this IServiceCollection services, Assembly targetAssembly)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(targetAssembly);

        var targets = targetAssembly.GetTypes()
            .Select(t => (type: t, attr: t.GetCustomAttributes().OfType<ServiceAttributeBase>().FirstOrDefault()))
            .Where(p => p.attr != null);

        foreach ((Type type, ServiceAttributeBase? attr) in targets)
        {
            var descriptor = ServiceDescriptor.Describe(attr!.ServiceType ?? type, attr.ImplType ?? type, attr.LifeTime);

            if (!attr.MultipleImplementation)
            {
                services.TryAdd(descriptor);
            }
            else
            {
                services.Add(descriptor);
            }
        }

        return services;
    }
}
