using System.Collections.Generic;
using System.Linq;

using GenHTTP.Api.Content;
using GenHTTP.Api.Protocol;
using GenHTTP.Modules.Basics;
using GenHTTP.Modules.Controllers;

using $safeprojectname$.Model;

namespace $safeprojectname$.Controllers
{

    public class BookController : AbstractController
    {
        private static readonly List<Book> _Books = new()
        {
            new Book(1, "Lord of The Rings")
        };

        public IHandlerBuilder Index()
        {
            return View("BookList.cshtml", "Book List", _Books);
        }

        public IHandlerBuilder Create()
        {
            return View("BookCreation.cshtml", "Add Book");
        }

        [ControllerAction(RequestMethod.POST)]
        public IHandlerBuilder Create(string title)
        {
            var book = new Book(_Books.Max(b => b.ID) + 1, title);

            _Books.Add(book);

            return Redirect.To("{index}/", true);
        }

        public IHandlerBuilder Edit([FromPath] int id)
        {
            var book = _Books.Where(b => b.ID == id).First();

            return View("BookEditor.cshtml", book.Title, book);
        }

        [ControllerAction(RequestMethod.POST)]
        public IHandlerBuilder Edit([FromPath] int id, string title)
        {
            var book = _Books.Where(b => b.ID == id).First();

            var index = _Books.IndexOf(book);

            _Books[index] = book with { Title = title };

            return Redirect.To("{index}/", true);
        }

        [ControllerAction(RequestMethod.POST)]
        public IHandlerBuilder Delete([FromPath] int id)
        {
            _Books.RemoveAll(b => b.ID == id);

            return Redirect.To("{index}/", true);
        }

    }

}
