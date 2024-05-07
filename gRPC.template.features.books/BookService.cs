using gRPC.template.features.books.DTOs;
using gRPC.template.features.books.infraestructure;

namespace gRPC.template.features.books;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public Task<Book> AddBook(Book book)
    {
        throw new NotImplementedException();
    }

    public Task<Book> DeleteBook(string name)
    {
        throw new NotImplementedException();
    }

    public Task<Book> GetBook(string name)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Book>> GetBooks()
    {
        throw new NotImplementedException();
    }

    public Task<Book> UpdateBook(Book book)
    {
        throw new NotImplementedException();
    }
}
