using gRPC.template.features.books.DTOs;

namespace gRPC.template.features.books;

public interface IBookService
{
    Task<IEnumerable<Book>> GetBooks();
    Task<Book> GetBook(string name);
    Task<Book> AddBook(Book book);
    Task<Book> UpdateBook(Book book);
    Task<Book> DeleteBook(string name);
}
