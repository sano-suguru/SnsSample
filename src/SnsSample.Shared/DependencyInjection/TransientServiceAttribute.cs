using Microsoft.Extensions.DependencyInjection;

namespace SnsSample.Shared.DependencyInjection;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class TransientServiceAttribute : ServiceAttributeBase
{
    public TransientServiceAttribute() : base(
        implType: null
        , serviceType: null
        , ServiceLifetime.Transient
        , multipleImplementation: true)
    {

    }
}

