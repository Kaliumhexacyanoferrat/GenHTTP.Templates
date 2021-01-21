using GenHTTP.Engine;

using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Practices;
using GenHTTP.Modules.Security;
using GenHTTP.Modules.Webservices;

using $safeprojectname$.Services;

var api = Layout.Create()
                .AddService<BookService>("books")
                .Add(CorsPolicy.Permissive());

return Host.Create()
           .Handler(api)
           .Defaults()
           .Console()
//-:cnd:noEmit
#if DEBUG
           .Development()
#endif
//+:cnd:noEmit
           .Run();