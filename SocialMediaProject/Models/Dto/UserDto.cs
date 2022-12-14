using System.ComponentModel.DataAnnotations;

namespace SocialMediaProject.Models.Dto
{
    public class UserDto
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
