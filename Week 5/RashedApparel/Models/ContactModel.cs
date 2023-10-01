using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RashedApparel.Models
{
    public class ContactModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        //The [Phone] validator wasn't good enough, in my opinion
        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$",
         ErrorMessage = "Please enter a valid phone number")]
        public string? Phone { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Message { get; set; }
    }
}
