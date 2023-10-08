using Ayakkabim.com.Data;
using Ayakkabim.com.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Linq;

namespace Ayakkabim.com.Controllers
{
    public class AccountController : Controller
    {
        private readonly AyakkabimcomContext _context;

        public AccountController(AyakkabimcomContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel data)
        {
            var user = _context.User.Where(x => x.Email == data.Email && x.password == data.Password).FirstOrDefault();
            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else {
                return RedirectToAction("Login");
            }

            
        }
    }
}
