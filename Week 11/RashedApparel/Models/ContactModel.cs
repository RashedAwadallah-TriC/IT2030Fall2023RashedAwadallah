using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RashedApparel.Models
{
    public class ContactModel
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(30)]
        [RegularExpression(@"^[a-zA-Z]+$",
         ErrorMessage = "Cannot contain special characters or numbers.")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30)]
        [RegularExpression(@"^[a-zA-Z]+$",
         ErrorMessage = "Cannot contain special characters or numbers.")]
        public string? LastName { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        //The [Phone] validator wasn't good enough, in my opinion
        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$",
         ErrorMessage = "Please enter a valid phone number - only 10 digits long.")]
        public string? Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        public string? Message { get; set; }
    }
}
