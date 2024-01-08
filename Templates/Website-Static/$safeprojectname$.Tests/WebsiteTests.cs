using System.Net;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GenHTTP.Testing;

namespace $safeprojectname$.Tests
{

    [TestClass]
    public class WebsiteTests
    {

        [TestMethod]
        public async Task TestCanFetchIndex()
        {
            using var runner = TestHost.Run(Project.Create());

            using var response = await runner.GetResponseAsync();

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

    }

}
