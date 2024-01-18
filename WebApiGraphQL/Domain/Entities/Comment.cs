using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiGraphQL.Domain.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public DateTime CreationDate { get; set; }


    }

}
