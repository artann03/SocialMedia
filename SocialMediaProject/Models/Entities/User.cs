using System.ComponentModel.DataAnnotations;

namespace SocialMediaProject.Models.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
