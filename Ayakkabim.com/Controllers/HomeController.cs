using Ayakkabim.com.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using Ayakkabim.com.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Ayakkabim.com.Controllers
{
  
    public class HomeController : Controller
    {
        private readonly AyakkabimcomContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AyakkabimcomContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() {

         List<Product> product = _context.Product.ToList();

           
            ViewBag.Product = product;
           



            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Man()
        {
            List<Product> product = _context.Product.Where(model => model.Gender == "Erkek").ToList();



            ViewBag.Product = product;

            return View(product);


        }
        public  IActionResult Woman()
        {
            List<Product> product = _context.Product.Where(model=>model.Gender=="Kadin").ToList();
           
            

            ViewBag.Product = product;
           
            return View(product);
        }
        public IActionResult Child()
        {
            List<Product> product = _context.Product.Where(model => model.Gender == "Cocuk").ToList();



            ViewBag.Product = product;

            return View(product);
        }
        public IActionResult Brand()
        {

           var  product = _context.Product.ToList().DistinctBy(x=>x.Brand).Select(x=>x.Brand);



            ViewBag.Product = product;

            return View(product);

        }

        public IActionResult BrandSearch(string Brandname) { 
        
            var product =_context.Product.Where(x=>x.Brand==Brandname).ToList();
            
            ViewBag.Product = product;

            return View(product);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}