using GenHTTP.Api.Content;

using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Security;
using GenHTTP.Modules.Controllers;

using $safeprojectname$.Controllers;

namespace $safeprojectname$
{
    
    public static class Project
    {

        public static IHandlerBuilder Setup()
        {
            return Layout.Create()
                         .AddController<DeviceController>("devices")
                         .Add(CorsPolicy.Permissive());
        }

    }

}
