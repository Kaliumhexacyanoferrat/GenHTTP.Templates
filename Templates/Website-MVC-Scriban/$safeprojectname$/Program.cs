using GenHTTP.Engine;

using GenHTTP.Modules.Controllers;
using GenHTTP.Modules.IO;
using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Markdown;
using GenHTTP.Modules.Practices;
using GenHTTP.Modules.Websites;

using GenHTTP.Themes.AdminLTE;

using $safeprojectname$.Controllers;

var index = ModMarkdown.Page(Resource.FromAssembly("Home.md"))
                       .Title("Home");

var resources = Resources.From(ResourceTree.FromAssembly("Static"));

var app = Layout.Create()
                .AddController<BookController>("books")
                .Index(index)
                .Add("static", resources);

var theme = Theme.Create()
                 .Title("Book Manager");

var menu = Menu.Empty()
               .Add("{website}", "Home")
               .Add("/books/", "Books");

var website = Website.Create()
                     .Theme(theme)
                     .Menu(menu)
                     .Content(app)
                     .AddScript("custom.js", Resource.FromAssembly("custom.js"))
                     .AddStyle("custom.css", Resource.FromAssembly("custom.css"));

return Host.Create()
           .Handler(website)
           .Defaults()
           .Console()
#if DEBUG
           .Development()
#endif
           .Run();