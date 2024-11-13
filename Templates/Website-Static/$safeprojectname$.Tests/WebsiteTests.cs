using System.Net;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GenHTTP.Testing;

namespace $safeprojectname$.Tests;

[TestClass]
public class WebsiteTests
{

    [TestMethod]
    public async Task TestCanFetchIndex()
    {
        await using var runner = await TestHost.RunAsync(Project.Create());

        using var response = await runner.GetResponseAsync();

        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }

}
