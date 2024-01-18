using Microsoft.EntityFrameworkCore;
using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.Infrastructure.Repositories
{
    public class CommentRepository : ICommentRepository
    {

        private readonly AppContextClass _contextClass;

        public CommentRepository(AppContextClass contextClass)
        {
            _contextClass = contextClass;
        }

        public List<Comment> GetAll()
        {
            return _contextClass.Comments
                .Include(a =>a.Author)
                .Include(p =>p.Post)
                .ToList();
        }

        public async Task<Comment> CreateComment(Comment c)
        {
            await _contextClass.Comments.AddAsync(c);
            await _contextClass.SaveChangesAsync();
            return c;
        }
    }
}
