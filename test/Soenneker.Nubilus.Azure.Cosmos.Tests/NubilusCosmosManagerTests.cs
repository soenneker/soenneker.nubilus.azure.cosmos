using Soenneker.Nubilus.Azure.Cosmos.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Nubilus.Azure.Cosmos.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class NubilusCosmosManagerTests : HostedUnitTest
{
    private readonly INubilusCosmosManager _util;

    public NubilusCosmosManagerTests(Host host) : base(host)
    {
        _util = Resolve<INubilusCosmosManager>(true);
    }

    [Test]
    public void Default()
    {

    }
}
