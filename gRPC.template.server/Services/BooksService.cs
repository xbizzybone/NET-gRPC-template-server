namespace gRPC.template.server.Services
{
    public class BooksService : Books.BooksBase
    {
        private readonly ILogger<BooksService> _logger;
        public BooksService(ILogger<BooksService> logger)
        {
            _logger = logger;
        }

        public override Task<BookResponse> SendBook(BookRequest request, ServerCallContext context)
        {
            return Task.FromResult(new BookResponse
            {
                Message = "Book Name " + request.Name
            });
        }
    }
}
