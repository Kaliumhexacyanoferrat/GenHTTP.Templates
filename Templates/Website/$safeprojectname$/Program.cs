using GenHTTP.Engine;

using GenHTTP.Modules.IO;
using GenHTTP.Modules.Practices;
using GenHTTP.Modules.Websites;

using GenHTTP.Themes.Lorahost;

using $safeprojectname$;

var project = Project.Create();

var theme = Theme.Create()
                 .Title("$safeprojectname$")
                 .Subtitle("This is text.")
                 .Action("/section-1/", "Go to Section 1")
                 .Header(Resource.FromAssembly("header.jpg"));

var menu = Menu.Empty()
               .Add("{website}/", "Home")
               .Add("section-1", "Section 1", new() { ("/sub/", "Sub Section") })
               .Add("section-2", "Section 2")
               .Add("about", "About");

var website = Website.Create()
                     .Theme(theme)
                     .Menu(menu)
                     .Content(project)
                     .AddScript("custom.js", Resource.FromAssembly("custom.js"))
                     .AddStyle("custom.css", Resource.FromAssembly("custom.css"));

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