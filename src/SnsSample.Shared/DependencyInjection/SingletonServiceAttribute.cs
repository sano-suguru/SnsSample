using Microsoft.Extensions.DependencyInjection;

namespace SnsSample.Shared.DependencyInjection;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class SingletonServiceAttribute : ServiceAttributeBase
{
    public SingletonServiceAttribute() : base(
        implType: null
        , serviceType: null
        , lifeTime: ServiceLifetime.Singleton
        , multipleImplementation: true)
    {
    }
}

