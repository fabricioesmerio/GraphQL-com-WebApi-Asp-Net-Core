using WebApiGraphQL.Application.Services;
using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.GraphQL.Mutation
{
    [ExtendObjectType("Mutation")]
    public class PostMutation
    {
        public async Task<Post> AddPost([Service] IPostService _service, PostCreateDto post)
        {
            return await _service.Add(post);
        }
    }
}
