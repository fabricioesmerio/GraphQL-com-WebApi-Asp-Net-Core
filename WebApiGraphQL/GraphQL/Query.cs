using WebApiGraphQL.Application.Services;
using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.GraphQL
{
    public class Query
    {
        public List<Author> GetAllAuthor([Service] IAuthorService _service)
        {
            return _service.GetAll();
        }
    }
}
