using System.ComponentModel.DataAnnotations;

namespace Exam8_MasterDetailsInCoreAPIwithAuth.DTOs
{
    public class UserLoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
