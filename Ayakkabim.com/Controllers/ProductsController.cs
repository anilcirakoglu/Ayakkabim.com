using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ayakkabim.com.Data;
using Ayakkabim.com.Models;
using System.IO;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Drawing.Drawing2D;

namespace Ayakkabim.com.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AyakkabimcomContext _context;

        public ProductsController(AyakkabimcomContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.id == id);
            var Product = new Product()
            {
                id = product.id,
                name = product.name,
                Price = product.Price,
                ShoesSize = product.ShoesSize,
                Gender = product.Gender,
                Brand = product.Brand,
                Image = product.Image


            };
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        [HttpGet]
        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }




        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,Price,ShoesSize,Gender,Brand,Image")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,Price,ShoesSize,Gender,Brand,Image")] Product product)
        {
            if (id != product.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Product == null)
            {
                return Problem("Entity set 'AyakkabimcomContext.Product'  is null.");
            }
            var product = await _context.Product.FindAsync(id);
            if (product != null)
            {
                _context.Product.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.id == id);
        }
        public async Task<IActionResult> ProductBuy(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.id == id);
            var Product = new Product()
            {
                id = product.id,
                name = product.name,
                Price = product.Price,
                ShoesSize = product.ShoesSize,
                Gender = product.Gender,
                Brand = product.Brand,
                Image = product.Image


            };
            if (product == null)
            {
                return NotFound();
            }

            return View(product);

        }
        
        public async Task<IActionResult> SellingForm(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.id == id);
            var Product = new Product()
            {
                id = product.id,
                name = product.name,
                Price = product.Price,
                ShoesSize = product.ShoesSize,
                Gender = product.Gender,
                Brand = product.Brand,
                Image = product.Image


            };
            if (product == null)
            {
                return NotFound();
            }

            return View(product);


        }
        
        public async Task<IActionResult> Selling(int? id) {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.id == id);
            var Product = new Product()
            {
                id = product.id,
                name = product.name,
                Price = product.Price,
                ShoesSize = product.ShoesSize,
                Gender = product.Gender,
                Brand = product.Brand,
                Image = product.Image


            };
            if (product == null)
            {
                return NotFound();
            }

            return RedirectToAction("Index", "Home");


        }


    }
}
