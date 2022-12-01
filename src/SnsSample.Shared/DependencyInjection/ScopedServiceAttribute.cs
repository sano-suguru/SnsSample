using Microsoft.Extensions.DependencyInjection;

namespace SnsSample.Shared.DependencyInjection;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class ScopedServiceAttribute : ServiceAttributeBase
{
    public ScopedServiceAttribute() : base(
        implType: null
        , serviceType: null
        , lifeTime: ServiceLifetime.Scoped
        , multipleImplementation: true)
    {

    }
}
