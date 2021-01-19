using System.Collections.Generic;

using GenHTTP.Api.Protocol;

using GenHTTP.Modules.Webservices;

using App.Types;

namespace App.Services
{

    public class BookService
    {

        [ResourceMethod]
        public List<Book> GetBooks(int page, int pageSize)
        {
            // GET http://localhost:8080/books/
            return new()
            {
                new Book(1, "Lord of the Rings")
            };
        }

        [ResourceMethod(":id")]
        public Book? GetBook(int id)
        {
            // GET http://localhost:8080/books/:id/
            return null;
        }

        [ResourceMethod(RequestMethod.PUT)]
        public Book AddBook(Book book)
        {
            // PUT http://localhost:8080/books/
            return new Book(0, "");
        }

        [ResourceMethod(RequestMethod.POST)]
        public Book? UpdateBook(Book book)
        {
            // POST http://localhost:8080/books/
            return null;
        }

        [ResourceMethod(RequestMethod.DELETE, ":id")]
        public Book? DeleteBook(int id)
        {
            // DELETE http://localhost:8080/books/:id/
            return null;
        }

    }

}
