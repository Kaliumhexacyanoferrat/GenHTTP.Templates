using System.Net;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GenHTTP.Testing;

namespace $safeprojectname$.Tests;

[TestClass]
public class BookServiceTests
{

    [TestMethod]
    public async Task TestGetBooks()
    {
        await using var runner = await TestHost.RunAsync(Project.Setup());

        using var response = await runner.GetResponseAsync("/books/");

        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
    }

}
