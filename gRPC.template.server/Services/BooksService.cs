namespace gRPC.template.server.Services;

public class BooksService : Books.BooksBase
{
    private readonly ILogger<BooksService> _logger;
    private readonly IBookService _bookService;
    public BooksService(ILogger<BooksService> logger, IBookService bookService)
    {
        _logger = logger;
        _bookService = bookService;
    }

    public override async Task<MessageResponse> CreateBook(CreateBookRequest request, ServerCallContext context)
    {
        var id = Guid.NewGuid().ToString();

        Log.Information("Create Book Init - Id: {id}, Request: {@request}", id, request);

        var isValidDecimal = decimal.TryParse(request.Price, out decimal price) ? price : 0;

        if (isValidDecimal == 0)
        {
            Log.Error("Create Book Error - Id: {id}, Message: {message}", id, "Price is not valid");

            return new MessageResponse
            {
                Id = id,
                Message = "Price is not valid"
            };
        }


        var book = new features.books.DTOs.Book
        {
            Name = request.Name,
            Author = request.Author,
            Price = price,
            Category = request.Category
        };

        var result = await _bookService.AddBook(book);

        Log.Information("Create Book End - Id: {id}, Result: {@result}", id, result);

        return new MessageResponse
        {
            Id = id,
            Message = "Book created successfully"
        };
    }

    public override async Task<ReadBookResponse> ReadBook(BookIdentifier request, ServerCallContext context)
    {
        var id = Guid.NewGuid().ToString();

        Log.Information("Read Book Init - Id: {id}", id);

        var result = await _bookService.GetBook(id);

        Log.Information("Read Book End - Id: {id}, Result: {@result}", id, result);

        return new ReadBookResponse
        {
            Id = result.Id,
            Name = result.Name,
            Author = result.Author,
            Price = result.Price.ToString(),
            Category = result.Category
        };
    }

    public override async Task<BooksResponse> ReadBooks(Empty request, ServerCallContext context)
    {
        var id = Guid.NewGuid().ToString();

        Log.Information("Read Books Init - Id: {id}", id);

        var result = await _bookService.GetBooks();

        Log.Information("Read Books End - Id: {id}, Result: {@result}", id, result);

        var books = new BooksResponse();

        foreach (var item in result)
        {
            books.Books.Add(new ReadBookResponse
            {
                Id = item.Id.ToString(),
                Name = item.Name,
                Author = item.Author,
                Price = item.Price.ToString(),
                Category = item.Category
            });
        }

        return books;
    }

    public override async Task<MessageResponse> UpdateBook(UpdateBookRequest request, ServerCallContext context)
    {
        var id = Guid.NewGuid().ToString();

        Log.Information("Update Book Init - Id: {id}, Request: {@request}", id, request);

        var isValidDecimal = decimal.TryParse(request.Price, out decimal price) ? price : 0;

        if (isValidDecimal == 0)
        {
            Log.Error("Update Book Error - Id: {id}, Message: {message}", id, "Price is not valid");

            return new MessageResponse
            {
                Id = id,
                Message = "Price is not valid"
            };
        }

        var book = new features.books.DTOs.Book
        {
            Id = request.Id,
            Name = request.Name,
            Author = request.Author,
            Price = price,
            Category = request.Category
        };

        var result = await _bookService.UpdateBook(request.Id, book);

        Log.Information("Update Book End - Id: {id}, Result: {@result}", id, result);

        return new MessageResponse
        {
            Id = id,
            Message = "Book updated successfully"
        };
    }

    public override async Task<MessageResponse> DeleteBook(BookIdentifier request, ServerCallContext context)
    {
        var id = Guid.NewGuid().ToString();

        Log.Information("Delete Book Init - Id: {id}", id);

        var result = await _bookService.DeleteBook(request.Id);

        Log.Information("Delete Book End - Id: {id}, Result: {@result}", id, result);

        return new MessageResponse
        {
            Id = id,
            Message = "Book deleted successfully"
        };
    }
}
