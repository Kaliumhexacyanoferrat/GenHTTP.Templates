using GenHTTP.Api.Content;

using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Security;
using GenHTTP.Modules.Functional;

namespace $safeprojectname$;

record class Book(int ID, string Title);

public static class Project
{

    public static IHandlerBuilder Setup()
    {
        // run this project and fetch a list of book records via http://localhost:8080/books/
        var books = new List<Book>()
        {
            new Book(1, "Lord of the Rings")
        };

        // see https://genhttp.org/documentation/content/frameworks/functional/
        var bookApi = Inline.Create()
                            .Get(() => books)
                            .Put((Book book) => books.Add(book));

        return Layout.Create()
                     .Add("books", bookApi)
                     .Add(CorsPolicy.Permissive());
    }

}
