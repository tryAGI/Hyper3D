namespace Hyper3D.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static Hyper3DClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HYPER3D_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("HYPER3D_API_KEY environment variable is not found.");

        var client = new Hyper3DClient(apiKey);
        
        return client;
    }
}
