using GenHTTP.Api.Content;

using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Security;
using GenHTTP.Modules.Functional;
using GenHTTP.Modules.OpenApi;
using GenHTTP.Modules.ApiBrowsing;

namespace $safeprojectname$;

record class Book(int ID, string Title);

public static class Project
{

    public static IHandlerBuilder Setup()
    {
        var books = new List<Book>()
        {
            new Book(1, "Lord of the Rings")
        };

        var bookApi = Inline.Create()
                            .Get(() => books)
                            .Put((Book book) => books.Add(book));

        return Layout.Create()
                     .Add("books", bookApi)
                     .AddOpenApi()
                     .AddSwaggerUI(segment: "docs")
                     .Add(CorsPolicy.Permissive());
    }

}
