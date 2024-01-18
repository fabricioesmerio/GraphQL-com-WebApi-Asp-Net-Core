using WebApiGraphQL.Application.Services;
using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.GraphQL.Mutation
{
    [ExtendObjectType("Mutation")]
    public class CommentMutation
    {
        public async Task<Comment> AddComment([Service] ICommentService service, CommentCreateDto comment)
        {
            return await service.CreateComment(comment);
        }
    }
}
