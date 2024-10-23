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
                              })
                              .OnClose((socket) =>
                              {
                                  Console.WriteLine("Close!");
                                  _AllSockets.Remove(socket);
                              })
                              .OnMessage((socket, message) =>
                              {
                                  Console.WriteLine(message);
                                  _AllSockets.ForEach(s => s.Send("Echo: " + message));
                              });

        return Layout.Create()
                     .Add("socket", socket) // ws://localhost:8080/socket/
                     .Add(client);
    }

}
