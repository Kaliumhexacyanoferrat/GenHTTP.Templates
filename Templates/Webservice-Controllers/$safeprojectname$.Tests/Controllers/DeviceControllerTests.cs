using System.Net;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GenHTTP.Testing;

namespace $safeprojectname$.Tests.Controllers
{

    [TestClass]
    public class DeviceControllerTests
    {

        [TestMethod]
        public async Task TestGetDevices()
        {
            using var runner = TestHost.Run(Project.Setup());

            using var response = await runner.GetResponseAsync("/devices/");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

    }

}
