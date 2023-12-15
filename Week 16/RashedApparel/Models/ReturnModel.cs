using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// THIS ENTIRE PAGE IS A NEW FEATURE

namespace RashedApparel.Models
{
    public class ReturnModel
    {
        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z]+$",
         ErrorMessage = "Cannot contain special characters or numbers.")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z]+$",
         ErrorMessage = "Cannot contain special characters or numbers.")]
        public string? LastName { get; set; }

        [Required]
        [Display(Name = "Order ID")]
        [RegularExpression(@"^[0-9]*$",
         ErrorMessage = "Cannot contain letters or special characters - numbers only.")]
        public string? OrderId { get; set; }

        [Required(ErrorMessage = "Please input valid address!")]
        public string? Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$",
        ErrorMessage = "Please enter a valid phone number - only 10 digits long.")]
        public string? Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please input a valid message!")]
        [Display(Name = "Reason for Return")]
        public string? Message { get; set; }


    }
}
