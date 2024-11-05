using System.Net;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GenHTTP.Testing;

namespace $safeprojectname$.Tests;

[TestClass]
public class SocketTests
{

    [TestMethod]
    public async Task TestSocket()
    {
        using var runner = TestHost.Run(Project.Setup());

        // add your test code here, e.g. using Websocket.Client
    }

}
