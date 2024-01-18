using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.Infrastructure.Repositories
{
    public interface IPostRepository
    {
        List<Post> GetAll();
        Task<Post> AddPost(Post post);
    }
}
