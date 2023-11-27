using System.Collections.Generic;

using GenHTTP.Engine;

using GenHTTP.Modules.Functional;
using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Practices;
using GenHTTP.Modules.Security;

// run this project and fetch a list of book records via http://localhost:8080/books/
var books = new List<Book>()
{
  new Book(1, "Lord of the Rings")
};

// see https://genhttp.org/documentation/content/functional
var bookApi = Inline.Create()
                    .Get(() => books)
                    .Put((Book book) => books.Add(book));

var content = Layout.Create()
                    .Add("books", bookApi)
                    .Add(CorsPolicy.Permissive());

return Host.Create()
           .Handler(content)
           .Defaults()
           .Console()
//-:cnd:noEmit
#if DEBUG
           .Development()
#endif
//+:cnd:noEmit
           .Run();

record class Book(int ID, string Title);