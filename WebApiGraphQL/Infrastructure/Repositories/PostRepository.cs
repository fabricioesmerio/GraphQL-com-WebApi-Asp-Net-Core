using Microsoft.EntityFrameworkCore;
using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {

        private readonly AppContextClass _contextClass;

        public PostRepository(AppContextClass contextClass)
        {
            _contextClass = contextClass;
        }

        public List<Post> GetAll()
        {
            return _contextClass.Posts
                .Include(a => a.Author)
                .Include(c => c.Comments)
                .ToList();
        }

        public async Task<Post> AddPost(Post post)
        {
            await _contextClass.Posts.AddAsync(post);
            await _contextClass.SaveChangesAsync();
            return post;
        }
    }
}
