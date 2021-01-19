using App.Services;

using GenHTTP.Engine;

using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Practices;
using GenHTTP.Modules.Webservices;

var api = Layout.Create()
                .AddService<BookService>("books");

return Host.Create()
           .Handler(api)
           .Defaults()
#if DEBUG
           .Development()
#endif
           .Console()
           .Run();