using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.Application.Services
{
    public interface IAuthorService
    {
        List<Author> GetAll();
        Author GetAuthorById(int id);
        Task<Author> CreateAuthor(AuthorCreateDto author);
        Task<Author> UpdateAuthor(Author author);
    }
}
