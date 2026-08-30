using Azure.Core;
using Azure.ResourceManager.CosmosDB;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Nubilus.Azure.Cosmos.Abstract;

/// <summary>
/// Resolves Azure Cosmos DB resources through Azure Resource Manager.
/// </summary>
public interface INubilusCosmosManager
{
    /// <summary>
    /// Fetches an existing Cosmos DB account by its complete ARM resource identifier.
    /// </summary>
    /// <param name="resourceIdentifier">Complete resource identifier for a Microsoft.DocumentDB database account.</param>
    /// <param name="cancellationToken">Token used to cancel authentication or the ARM request.</param>
    /// <returns>The current Cosmos DB account resource returned by Azure Resource Manager.</returns>
    ValueTask<CosmosDBAccountResource> GetAccount(ResourceIdentifier resourceIdentifier, CancellationToken cancellationToken = default);
}
