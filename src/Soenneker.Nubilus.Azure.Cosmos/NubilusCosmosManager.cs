using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB;
using Soenneker.Azure.Utils.ArmClientUtil.Abstract;
using Soenneker.Nubilus.Azure.Cosmos.Abstract;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Nubilus.Azure.Cosmos;

public sealed class NubilusCosmosManager : INubilusCosmosManager
{
    private readonly IArmClientUtil _armClientUtil;

    public NubilusCosmosManager(IArmClientUtil armClientUtil)
    {
        _armClientUtil = armClientUtil;
    }

    public async ValueTask<CosmosDBAccountResource> GetAccount(ResourceIdentifier resourceIdentifier, CancellationToken cancellationToken = default)
    {
        ArmClient client = await _armClientUtil.Get(cancellationToken).ConfigureAwait(false);
        CosmosDBAccountResource account = client.GetCosmosDBAccountResource(resourceIdentifier);
        Response<CosmosDBAccountResource> response = await account.GetAsync(cancellationToken).ConfigureAwait(false);

        return response.Value;
    }
}
