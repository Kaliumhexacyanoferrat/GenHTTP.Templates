using GenHTTP.Api.Content;

using GenHTTP.Modules.IO;
using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.SinglePageApplications;

namespace $safeprojectname$;

public static class Project
{

    public static IHandlerBuilder Setup()
    {
        //
        // depending on your needs, update this section to define where your
        // single page application distribution files are loaded from
        //
        // if you would like to productively host your SPA somewhere, you might want to ...
        //
        // - use a debug directive to load another directory locally as in production
        // - use an environment variable to pass the path to the application
        // - ...
        //
        var distRoot = ResourceTree.FromDirectory(@"C:\Projects\some-app\dist\some-app\browser\");

        var spa = SinglePageApplication.From(distRoot)
                                       .ServerSideRouting();

        //
        // if you would like to host some API for your app, you can create
        // services and add them to your app's layout here (e.g. via AddService<T>)
        //
        // for this purpose, there are various frameworks and nuget packages available:
        //
        // - web services (https://genhttp.org/documentation/content/webservices/)
        // - functional handlers (https://genhttp.org/documentation/content/functional/)
        // - controllers (https://genhttp.org/documentation/content/controllers/)
        //
        return Layout.Create()
                     .Add(spa);
    }

}
