using GenHTTP.Api.Content;

using GenHTTP.Modules.IO;
using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.ServerSentEvents;

namespace $safeprojectname$;

public static class Project
{

    public static IHandlerBuilder Setup()
    {
        var client = Content.From(Resource.FromAssembly("client.html"));

        var stocks = EventSource.Create()
                                .Generator(GenerateStock);

        return Layout.Create()
                     .Add("stock", stocks)
                     .Index(client);
    }

    private static async ValueTask GenerateStock(IEventConnection connection)
    {
        var rand = new Random();

        var stockSymbols = new List<string> { "AAPL", "GOOGL", "MSFT" };

        await connection.CommentAsync("Sending stock data");

        while (connection.Connected)
        {
            var symbol = stockSymbols[rand.Next(0, 3)];

            await connection.DataAsync(rand.Next(100, 1000), symbol);

            await Task.Delay(1000);
        }

    }

}
