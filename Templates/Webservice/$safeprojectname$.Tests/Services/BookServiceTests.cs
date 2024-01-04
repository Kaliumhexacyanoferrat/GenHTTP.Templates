using System.Net;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GenHTTP.Testing;

namespace $safeprojectname$.Tests.Services
{

    [TestClass]
    public class BookServiceTests
    {

        [TestMethod]
        public async Task TestGetLordOfTheRings()
        {
            using var runner = TestHost.Run(Project.Setup());

            using var response = await runner.GetResponseAsync("/books/");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

    }

}
