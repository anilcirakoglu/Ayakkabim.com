using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace Ayakkabim.com.Models
{
    public class Product
    {
        public int id { get; set; }
        public string? name { get; set; }
        public decimal Price { get; set; }
        public decimal ShoesSize { get; set; }
        public string? Gender { get; set; }
        public string? Brand { get; set; }
        [Display(Name = "Image")]
        public string? Image { get; set; }

    }
   
}
