using Soenneker.Nubilus.Azure.Cosmos.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Nubilus.Azure.Cosmos.Tests;

[Collection("Collection")]
public class NubilusCosmosManagerTests : FixturedUnitTest
{
    private readonly INubilusCosmosManager _util;

    public NubilusCosmosManagerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<INubilusCosmosManager>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
