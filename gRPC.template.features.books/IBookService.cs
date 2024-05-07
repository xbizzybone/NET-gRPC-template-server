using gRPC.template.features.books.DTOs;

namespace gRPC.template.features.books;

public interface IBookService
{
    Task<IEnumerable<Book>> GetBooks();
    Task<Book> GetBook(string id);
    Task<Book> AddBook(Book book);
    Task<Book> UpdateBook(string id, Book book);
    Task<Book> DeleteBook(string id);
}
