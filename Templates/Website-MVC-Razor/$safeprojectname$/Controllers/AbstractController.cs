using GenHTTP.Api.Content;
using GenHTTP.Api.Content.Templating;

using GenHTTP.Modules.IO;
using GenHTTP.Modules.Razor;

namespace $safeprojectname$.Controllers
{

    public abstract class AbstractController
    {

        protected IHandlerBuilder View<T>(string file, string title, T data) where T : class
        {
            return ModRazor.Page<ViewModel<T>>(Resource.FromAssembly(file), (r, h) => new(new ViewModel<T>(r, h, data)))
                           .Title(title);
        }

        protected IHandlerBuilder View(string file, string title)
        {
            return ModRazor.Page(Resource.FromAssembly(file))
                           .Title(title);
        }

    }

}
