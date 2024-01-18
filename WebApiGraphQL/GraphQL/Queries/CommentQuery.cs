using WebApiGraphQL.Application.Services;
using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.GraphQL.Queries
{
    [ExtendObjectType("Query")]
    public class CommentQuery
    {

        public List<Comment> GetAllComments([Service] ICommentService _service)
        {
            return _service.GetAll();
        }
    }
}
