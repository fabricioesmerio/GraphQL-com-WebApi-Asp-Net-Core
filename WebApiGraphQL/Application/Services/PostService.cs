using WebApiGraphQL.Domain.Entities;
using WebApiGraphQL.Infrastructure.Repositories;

namespace WebApiGraphQL.Application.Services
{
    public class PostService : IPostService
    {

        private readonly IPostRepository _repo;

        public PostService(IPostRepository repo)
        {
            _repo = repo;
        }

        public List<Post> GetAll()
        {
            return _repo.GetAll();
        }

        public async Task<Post> Add(PostCreateDto postDto)
        {
            Post post = new()
            {
                Title = postDto.Title,
                AuthorId =  postDto.AuthorId,
                Content = postDto.Content,
                PublicationDate = postDto.PublicationDate
            };
            return await _repo.AddPost(post);
        }
    }
}
