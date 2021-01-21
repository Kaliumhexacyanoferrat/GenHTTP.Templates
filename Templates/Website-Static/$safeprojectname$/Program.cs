using GenHTTP.Engine;

using GenHTTP.Modules.IO;
using GenHTTP.Modules.Practices;
using GenHTTP.Modules.StaticWebsites;

var files = ResourceTree.FromAssembly("Content"); // or FromDirectory("/var/www/")

var website = StaticWebsite.From(files);

return Host.Create()
           .Handler(website)
           .Defaults()
           .Console()
//-:cnd:noEmit
#if DEBUG
           .Development()
#endif
//+:cnd:noEmit
           .Run();