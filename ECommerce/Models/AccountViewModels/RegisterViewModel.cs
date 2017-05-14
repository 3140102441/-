using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [RegularExpression(@"[a-zA-Z0-9]+")]
        [StringLength(30, MinimumLength = 4)]
        public string UserName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
