using System.ComponentModel.DataAnnotations;

namespace apiaprendizaje_api.Models.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Role { get; set; }
    }
}
