using System.ComponentModel.DataAnnotations;

namespace RashedApparel.Models
{
    public class MySession
    {


        [Display(Name = "First Name")]
        public string? FirstName { get; set; }


        [Display(Name = "Last Name")]
        public string? LastName { get; set; }


        public string? Course { get; set; }


        [Display(Name = "Favorite Number")]
        public string? FavNumber { get; set; }
    }
}
