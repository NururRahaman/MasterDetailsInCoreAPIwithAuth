﻿using System.ComponentModel.DataAnnotations;

namespace Exam8_MasterDetailsInCoreAPIwithAuth.DTOs
{
    public class UserRegistrationDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
