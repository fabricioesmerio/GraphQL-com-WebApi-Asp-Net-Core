using WebApiGraphQL.Application.Services;
using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.GraphQL.Queries
{
    [ExtendObjectType("Query")]
    public class AuthorQuery
    {
        public List<Author> GetAllAuthor([Service] IAuthorService _service)
        {
            return _service.GetAll();
        }

        public Author GetAllAuthorById([Service] IAuthorService _service, int id)
        {
            return _service.GetAuthorById(id);
        }
    }
}
