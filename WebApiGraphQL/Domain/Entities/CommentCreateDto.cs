namespace WebApiGraphQL.Domain.Entities
{
    public class CommentCreateDto
    {
        public string Text { get; set; }
        public int PostId { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
