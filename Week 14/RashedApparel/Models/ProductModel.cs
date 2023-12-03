using System.ComponentModel.DataAnnotations;

namespace RashedApparel.Models
{
    public class ProductModel
    {
        [Required]
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Must include a name.")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Must include a description.")]
        public string ProductDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Must include an image.")]
        public string ProductImage { get; set; } = string.Empty;

        [Required(ErrorMessage = "Must include a price.")]
        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; } 
    }
}
