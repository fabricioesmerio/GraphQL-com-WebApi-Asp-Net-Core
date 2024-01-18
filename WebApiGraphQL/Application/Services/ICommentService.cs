using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.Application.Services
{
    public interface ICommentService
    {
        List<Comment> GetAll();
        Task<Comment> CreateComment(CommentCreateDto dto);
    }
}
