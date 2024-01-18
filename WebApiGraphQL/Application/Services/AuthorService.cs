using WebApiGraphQL.Domain.Entities;
using WebApiGraphQL.Infrastructure.Repositories;

namespace WebApiGraphQL.Application.Services
{
    public class AuthorService : IAuthorService
    {

        private readonly IAuthorRepository _repo;

        public AuthorService(IAuthorRepository repo)
        {
            _repo = repo;
        }

        public List<Author> GetAll() { return _repo.GetAll(); }

        public Author GetAuthorById(int id)
        {
            return _repo.GetAuthorById(id);
        }

        public async Task<Author> CreateAuthor(AuthorCreateDto authorDto)
        {
            Author author = new();
            author.Name = authorDto.Name;
            return await _repo.CreateAuthor(author);
        }

        public async Task<Author> UpdateAuthor(Author author)
        {
            return await _repo.UpdateAuthor(author);
        }
    }
}
