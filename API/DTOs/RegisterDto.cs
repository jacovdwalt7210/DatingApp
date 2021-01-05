using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(32, MinimumLength = 4)]
        public string Password { get; set; }
    }
}