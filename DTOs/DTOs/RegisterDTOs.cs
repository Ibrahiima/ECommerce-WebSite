using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace DTOs 
{ 

    public class RegisterDTOs
    {

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [ContainValidation]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and confirmation password do not match. Please ensure that both passwords are identical and try again.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
