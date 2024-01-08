using System.Net;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GenHTTP.Testing;

namespace $safeprojectname$.Tests
{

    [TestClass]
    public class BookControllerTests
    {

        [TestMethod]
        public async Task TestCanFetchBooks()
        {
            using var runner = TestHost.Run(Project.Create());

            using var response = await runner.GetResponseAsync("/books/");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

    }

}
