using Xunit;

namespace FluxoFacebook.Fixtures
{
    [CollectionDefinition("Chrome Driver")]
    public class CollectionFixture : ICollectionFixture<TestFixture>
    {
    }
}
