using WebApiGraphQL.Application.Services;
using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.GraphQL.Mutation
{
    [ExtendObjectType("Mutation")]
    public class AuthorMutation
    {

        public async Task<Author> AddAuthor([Service] IAuthorService _service, AuthorCreateDto author)
        {
            return await _service.CreateAuthor(author);
        }

        public async Task<Author> UpdateAuthor([Service] IAuthorService _service, Author author)
        {
            return await _service.UpdateAuthor(author);
        }
    }
}
