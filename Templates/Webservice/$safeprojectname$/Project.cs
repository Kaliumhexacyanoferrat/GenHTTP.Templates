using GenHTTP.Api.Content;

using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Security;
using GenHTTP.Modules.Webservices;
using GenHTTP.Modules.OpenApi;

using $safeprojectname$.Services;

namespace $safeprojectname$;

public static class Project
{

    public static IHandlerBuilder Setup()
    {
        return Layout.Create()
                     .AddService<BookService>("books")
                     .AddOpenApi()
                     .Add(CorsPolicy.Permissive());
    }

}
