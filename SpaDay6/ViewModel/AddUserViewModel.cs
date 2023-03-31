using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Must have username")]
        [StringLength(15, MinimumLength = 5, ErrorMessage ="Username must be between 5 and 15 characters.")]
        public string? Username { get; set; }

        [EmailAddress(ErrorMessage ="Email address must be in the right format.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Must enter a password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The password must be between 6 and 20 characters")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Re-enter your password")]
        [Compare("Password", ErrorMessage="Passwords do not match.")]
        public string? VerifyPassword { get; set; }
       
        
    }
}
