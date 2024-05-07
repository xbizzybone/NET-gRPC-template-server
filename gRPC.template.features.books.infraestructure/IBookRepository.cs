using gRPC.template.features.books.infraestructure.Models;

namespace gRPC.template.features.books.infraestructure;

public interface IBookRepository
{
    Task<List<Book>> GetAsync();
    Task<Book?> GetAsync(string name);
    Task CreateAsync(Book book);
    Task UpdateAsync(string id, Book updatedBook);
    Task RemoveAsync(string id);
}
