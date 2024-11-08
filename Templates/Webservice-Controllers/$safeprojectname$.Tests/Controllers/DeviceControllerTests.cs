using System.Net;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GenHTTP.Testing;

namespace $safeprojectname$.Tests.Controllers;

[TestClass]
public class DeviceControllerTests
{

    [TestMethod]
    public async Task TestGetDevices()
    {
        await using var runner = await TestHost.RunAsync(Project.Setup());

        using var response = await runner.GetResponseAsync("/devices/");

        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }

}
