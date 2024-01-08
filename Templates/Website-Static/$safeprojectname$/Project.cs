using GenHTTP.Api.Content;

using GenHTTP.Modules.IO;
using GenHTTP.Modules.StaticWebsites;

namespace $safeprojectname$
{

    public static class Project
    {

        public static IHandlerBuilder Create()
        {
            var files = ResourceTree.FromAssembly("Content"); // or FromDirectory("/var/www/")

            return StaticWebsite.From(files);
        }

    }

}
