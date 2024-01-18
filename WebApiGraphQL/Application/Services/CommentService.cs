using WebApiGraphQL.Domain.Entities;
using WebApiGraphQL.Infrastructure.Repositories;

namespace WebApiGraphQL.Application.Services
{
    public class CommentService : ICommentService
    {

        private readonly ICommentRepository _repo;

        public CommentService(ICommentRepository repo) {  _repo = repo; }

        public List<Comment> GetAll() { return _repo.GetAll(); }

        public async Task<Comment> CreateComment(CommentCreateDto dto)
        {
            Comment comment = new()
            {
                AuthorId = dto.AuthorId,
                CreationDate = dto.CreationDate,
                PostId = dto.PostId,
                Text = dto.Text
            };
            return await _repo.CreateComment(comment);
        }
    }
}
