using System;
using System.Collections.Generic;

using GenHTTP.Api.Protocol;

using GenHTTP.Modules.Webservices;

using $safeprojectname$.Model;

namespace $safeprojectname$.Services
{

    // For documentation, see: https://genhttp.org/documentation/content/webservices

    public class BookService
    {

        [ResourceMethod]
        public List<Book> GetBooks(int page, int pageSize)
        {
            // GET http://localhost:8080/books/?page=1&pageSize=20
            return new()
            {
                new Book(1, "Lord of the Rings")
            };
        }

        [ResourceMethod(":id")]
        public Book? GetBook(int id)
        {
            // GET http://localhost:8080/books/:id/
            throw new NotImplementedException();
        }

        [ResourceMethod(RequestMethod.PUT)]
        public Book AddBook(Book book)
        {
            // PUT http://localhost:8080/books/
            throw new NotImplementedException();
        }

        [ResourceMethod(RequestMethod.POST)]
        public Book? UpdateBook(Book book)
        {
            // POST http://localhost:8080/books/
            throw new NotImplementedException();
        }

        [ResourceMethod(RequestMethod.DELETE, ":id")]
        public Book? DeleteBook(int id)
        {
            // DELETE http://localhost:8080/books/:id/
            throw new NotImplementedException();
        }

    }

}
