using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Controllers
{
    public class UserforLoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string  Password { get; set; }
    }
}