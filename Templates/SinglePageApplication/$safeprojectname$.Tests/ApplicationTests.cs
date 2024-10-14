using System.Net;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GenHTTP.Testing;

namespace $safeprojectname$.Tests;

[TestClass]
public class ApplicationTests
{

    [TestMethod]
    public async Task TestRoot()
    {
        using var runner = TestHost.Run(Project.Setup());

        using var response = await runner.GetResponseAsync();

        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }

}
