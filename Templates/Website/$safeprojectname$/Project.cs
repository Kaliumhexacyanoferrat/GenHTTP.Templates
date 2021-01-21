using GenHTTP.Api.Content;

using GenHTTP.Modules.IO;
using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Markdown;

namespace $safeprojectname$
{

    public static class Project
    {

        public static IHandlerBuilder Create()
        {
            var resources = Resources.From(ResourceTree.FromAssembly("Static"));

            var section1 = Layout.Create()
                                 .Index(GetPage("Section1.Index.md", "Section 1"))
                                 .Add("sub", GetPage("Section1.Sub.md", "Sub Section"));

            var section2 = Layout.Create()
                                 .Index(GetPage("Section2.Index.md", "Section 2"));

            return Layout.Create()
                         .Index(GetPage("Home.md", "Home"))
                         .Add("section-1", section1)
                         .Add("section-2", section2)
                         .Add("about", GetPage("About.md", "About"))
                         .Add("static", resources);
        }

        private static IHandlerBuilder GetPage(string file, string title, string? description = null)
        {
            var page = ModMarkdown.Page(Resource.FromAssembly(file))
                                  .Title(title);

            if (description != null)
            {
                page.Description(description);
            }

            return page;
        }

    }

}
