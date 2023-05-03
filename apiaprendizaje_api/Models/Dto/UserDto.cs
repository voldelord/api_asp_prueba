using System.ComponentModel.DataAnnotations;

namespace apiaprendizaje_api.Models.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Role { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(8)]
        public string Email { get; set; }
    }
}
