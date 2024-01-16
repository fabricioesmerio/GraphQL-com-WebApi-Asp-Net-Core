using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiGraphQL.Domain.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public List<Comment> Comments { get; set; }

 
    }
}
