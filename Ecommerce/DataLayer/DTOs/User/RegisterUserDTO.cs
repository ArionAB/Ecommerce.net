﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DataLayer.DTOs.User
{
    public class RegisterUserDTO
    {
        [Required]
        
        public string UserName { get; set; }

        [Required]

        public string Email { get; set; }

        [Required] 
        public string Password { get; set; }

        [Required]
        [Compare("Password")]

        public string ConfirmPassword { get; set; }

        


    }
}
