using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
namespace Ayakkabim.com.Views.viewModel
{
    public class UploadImageViewModel
    {
        [Display(Name = "Image")]
        public IFormFile Image { get; set; }
    }
}
