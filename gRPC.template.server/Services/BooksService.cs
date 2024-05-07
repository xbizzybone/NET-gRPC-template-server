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

    public override Task<BookResponse> SendBook(BookRequest request, ServerCallContext context)
    {
        return Task.FromResult(new BookResponse
        {
            Message = "Book Name " + request.Name
        });
    }
}
