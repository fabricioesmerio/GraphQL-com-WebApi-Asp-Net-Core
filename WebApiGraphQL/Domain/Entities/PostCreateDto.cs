namespace WebApiGraphQL.Domain.Entities
{
    public class PostCreateDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }
        public int AuthorId { get; set; }
    }
}
