using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.Infrastructure.Repositories
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();
        Author GetAuthorById(int id);
        Task<Author> CreateAuthor(Author author);
        Task<Author> UpdateAuthor(Author author);
    }
}
