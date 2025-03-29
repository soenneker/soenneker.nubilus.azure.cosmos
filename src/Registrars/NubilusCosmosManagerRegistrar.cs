using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Azure.Utils.ArmClientUtil.Registrars;
using Soenneker.Nubilus.Azure.Cosmos.Abstract;

namespace Soenneker.Nubilus.Azure.Cosmos.Registrars;

/// <summary>
/// An Azure Resource Manager for Azure Cosmos DB instances
/// </summary>
public static class NubilusCosmosManagerRegistrar
{
    /// <summary>
    /// Adds <see cref="INubilusCosmosManager"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddNubilusCosmosManagerAsSingleton(this IServiceCollection services)
    {
        services.AddArmClientUtilAsSingleton();
        services.TryAddSingleton<INubilusCosmosManager, NubilusCosmosManager>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="INubilusCosmosManager"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddNubilusCosmosManagerAsScoped(this IServiceCollection services)
    {
        services.AddArmClientUtilAsSingleton();
        services.TryAddScoped<INubilusCosmosManager, NubilusCosmosManager>();

        return services;
    }
}
