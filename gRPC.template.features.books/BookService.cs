using gRPC.template.features.books.DTOs;
using gRPC.template.features.books.infraestructure;
using Serilog;
using System.Net.WebSockets;

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
        try
        {
            var model = new infraestructure.Models.Book()
            {
                Name = book.Name,
                Author = book.Author,
                Price = book.Price,
                Category = book.Category
            };

            _bookRepository.CreateAsync(model);
            return Task.FromResult(book);
        }
        catch (Exception ex)
        {
            Log.Error(ex.Message);
            throw new Exception(ex.Message);
        }
    }

    public Task<Book> DeleteBook(string id)
    {
        try
        {
            _bookRepository.RemoveAsync(id);
            return Task.FromResult(new Book());
        }
        catch (Exception ex)
        {
            Log.Error(ex.Message);
            throw new Exception(ex.Message);
        }
    }

    public Task<Book> GetBook(string id)
    {
        try
        {
            var book = _bookRepository.GetAsync(id);
            return Task.FromResult(new Book()
            {
                Id = book.Result.Id,
                Name = book.Result.Name,
                Author = book.Result.Author,
                Price = book.Result.Price,
                Category = book.Result.Category
            });
        }
        catch (Exception ex)
        {
            Log.Error(ex.Message);
            throw new Exception(ex.Message);
        }
    }

    public Task<IEnumerable<Book>> GetBooks()
    {
        try
        {
            var books = _bookRepository.GetAsync();
            return Task.FromResult(books.Result.Select(book => new Book()
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                Price = book.Price,
                Category = book.Category
            }));
        }
        catch (Exception ex)
        {
            Log.Error(ex.Message);
            throw new Exception(ex.Message);
        }
    }

    public Task<Book> UpdateBook(string id, Book book)
    {
        try
        {
            var model = new infraestructure.Models.Book()
            {
                Id = id,
                Name = book.Name,
                Author = book.Author,
                Price = book.Price,
                Category = book.Category
            };

            _bookRepository.UpdateAsync(id, model);
            return Task.FromResult(book);
        }
        catch (Exception ex)
        {
            Log.Error(ex.Message);
            throw new Exception(ex.Message);
        }
    }
}
