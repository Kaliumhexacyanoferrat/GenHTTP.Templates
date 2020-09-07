using GenHTTP.Core;
using GenHTTP.Modules.Core;
using GenHTTP.Modules.Webservices;

using Server.Services;

namespace Server
{
    
    public static class Program
    {
        
        public static int Main(string[] args)
        {
#if DEBUG
            var app = ReverseProxy.Create()
                                  .Upstream("http://localhost:8081");
#else
            var app = SinglePageApplication.From("./App");
#endif

            var api = Layout.Create()
                            .Add<TaskResource>("tasks");

            var layout = Layout.Create()
                               .Add("api", api)
                               .Fallback(app);

            return Host.Create()
                       .Handler(layout)
#if DEBUG
                       .Development()
#endif
                       .Defaults()
                       .Console()
                       .Run();
        }
    
    }

}
