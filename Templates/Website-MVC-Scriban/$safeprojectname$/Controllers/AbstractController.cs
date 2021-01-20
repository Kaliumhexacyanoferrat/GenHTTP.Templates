using GenHTTP.Api.Content;
using GenHTTP.Api.Content.Templating;

using GenHTTP.Modules.IO;
using GenHTTP.Modules.Scriban;

namespace $safeprojectname$.Controllers
{

    public abstract class AbstractController
    {

        protected IHandlerBuilder View<T>(string file, string title, T data) where T : class
        {
            return ModScriban.Page(Resource.FromAssembly(file), (r, h) => new ViewModel<T>(r, h, data))
                             .Title(title);
        }

        protected IHandlerBuilder View(string file, string title)
        {
            return ModScriban.Page(Resource.FromAssembly(file))
                             .Title(title);
        }

    }

}
