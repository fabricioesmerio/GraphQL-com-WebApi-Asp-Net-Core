using WebApiGraphQL.Application.Services;
using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.GraphQL.Queries
{
    [ExtendObjectType("Query")]
    public class PostQuery
    {

        public List<Post> GetAllPost([Service] IPostService _service)
        {
            return _service.GetAll();
        }
    }
}
