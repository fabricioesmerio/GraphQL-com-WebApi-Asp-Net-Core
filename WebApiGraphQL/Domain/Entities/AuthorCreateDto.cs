using System.ComponentModel.DataAnnotations;

namespace WebApiGraphQL.Domain.Entities
{
    public class AuthorCreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
