using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.Infrastructure.Repositories
{
    public interface ICommentRepository
    {
        List<Comment> GetAll();
        Task<Comment> CreateComment(Comment c);
    }
}
