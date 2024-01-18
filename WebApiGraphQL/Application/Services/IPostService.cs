using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.Application.Services
{
    public interface IPostService
    {
        List<Post> GetAll();
        Task<Post> Add(PostCreateDto post);
    }
}
