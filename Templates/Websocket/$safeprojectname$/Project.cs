using GenHTTP.Api.Content;

using GenHTTP.Modules.IO;
using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Websockets;

namespace $safeprojectname$;

public static class Project
{
    private static List<IReactiveConnection> Clients = [];

    public static IHandlerBuilder Setup()
    {
        var client = Content.From(Resource.FromAssembly("client.html"));

        // see https://genhttp.org/documentation/content/frameworks/websockets/
        var socket = Websocket.Functional()
                              .OnConnected(c =>
                              {
                                  Clients.Add(c);
                                  return ValueTask.CompletedTask;
                              })
                              .OnMessage(async (c, m) =>
                              {
                                  var clientNumber = Clients.IndexOf(c);

                                  foreach (var client in Clients)
                                  {
                                      await client.WriteAsync($"[{clientNumber}]: " + m.DataAsString);
                                  }
                              })
                              .OnClose((c, _) =>
                              {
                                  Clients.Remove(c);
                                  return ValueTask.CompletedTask;
                              });

        return Layout.Create()
                     .Add("socket", socket) // ws://localhost:8080/socket/
                     .Add(client);
    }

}
