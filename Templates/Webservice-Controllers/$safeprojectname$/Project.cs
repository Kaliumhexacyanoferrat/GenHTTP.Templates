using GenHTTP.Api.Content;

using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Security;
using GenHTTP.Modules.Controllers;
using GenHTTP.Modules.OpenApi;
using GenHTTP.Modules.ApiBrowsing;

using $safeprojectname$.Controllers;

namespace $safeprojectname$;

public static class Project
{

    public static IHandlerBuilder Setup()
    {
        return Layout.Create()
                     .AddController<DeviceController>("devices")
                     .AddOpenApi()
                     .AddSwaggerUI(segment: "docs")
                     .Add(CorsPolicy.Permissive());
    }

}
