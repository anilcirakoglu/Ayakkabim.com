using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ayakkabim.com.Views.viewModel
{
    public class ProductviewModel : EditImageViewModel
    {

        [Required]
        public string? name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal ShoesSize { get; set; }



        [Required]
        public string? Gender { get; set; }


        [Required]
        public string? Brand { get; set; }

       
    }
}
