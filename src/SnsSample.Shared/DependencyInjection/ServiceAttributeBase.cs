using System;
using Microsoft.Extensions.DependencyInjection;

namespace SnsSample.Shared.DependencyInjection;

public abstract class ServiceAttributeBase : Attribute
{
    public Type? ImplType { get; }
    public Type? ServiceType { get; }
    public ServiceLifetime LifeTime { get; }
    public bool MultipleImplementation { get; }

    protected ServiceAttributeBase(
        Type? implType
        , Type? serviceType
        , ServiceLifetime lifeTime
        , bool multipleImplementation)
    {
        ImplType = implType;
        ServiceType = serviceType;
        LifeTime = lifeTime;
        MultipleImplementation = multipleImplementation;
    }
}
