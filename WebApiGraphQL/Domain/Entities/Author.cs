using System.ComponentModel.DataAnnotations;

namespace WebApiGraphQL.Domain.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
