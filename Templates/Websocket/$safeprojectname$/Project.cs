using GenHTTP.Api.Content;

using GenHTTP.Modules.IO;
using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Websockets;

namespace $safeprojectname$;

public static class Project
{
    private static List<IWebsocketConnection> _AllSockets = [];

    public static IHandlerBuilder Setup()
    {
        var client = Content.From(Resource.FromAssembly("client.html"));

        // see https://genhttp.org/documentation/content/frameworks/websockets/
        var socket = Websocket.Create()
                              .OnOpen((socket) =>
                              {
                                  Console.WriteLine("Open!");
                                  _AllSockets.Add(socket);

                                  return Task.CompletedTask;
                              })
                              .OnClose((socket) =>
                              {
                                  Console.WriteLine("Close!");
                                  _AllSockets.Remove(socket);
                                  
                                  return Task.CompletedTask;
                              })
                              .OnMessage(async (socket, message) =>
                              {
                                  Console.WriteLine(message);

                                  foreach (var s in _AllSockets)
                                  {
                                      await s.SendAsync("Echo: " + message);
                                  }
                              });

        return Layout.Create()
                     .Add("socket", socket) // ws://localhost:8080/socket/
                     .Add(client);
    }

}
