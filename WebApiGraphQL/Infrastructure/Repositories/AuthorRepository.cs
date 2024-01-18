using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly AppContextClass _contextClass;

        public AuthorRepository(AppContextClass contextClass)
        {
            _contextClass = contextClass;
        }

        public List<Author> GetAll()
        {
            return _contextClass.Authors.ToList();
        }

        public Author GetAuthorById(int id)
        {
            return _contextClass.Authors.Where(p => p.Id == id).FirstOrDefault();
        }

        public async Task<Author> CreateAuthor(Author author)
        {
            
            await _contextClass.Authors.AddAsync(author);
            await _contextClass.SaveChangesAsync();
            return author;
        }

        public async Task<Author> UpdateAuthor(Author author)
        {
            var updateAuthor = _contextClass.Authors.Find(author.Id);
            if (updateAuthor != null)
            {
                updateAuthor.Name = author.Name ?? updateAuthor.Name;
                
                _contextClass.Authors.Update(updateAuthor);
                await _contextClass.SaveChangesAsync();
            }

            return updateAuthor;
        }
    }
}
