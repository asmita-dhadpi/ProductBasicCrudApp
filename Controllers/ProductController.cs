using Microsoft.AspNetCore.Mvc;
using ProductCrudApp.Data;
using ProductCrudApp.Models;

namespace ProductCrudApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string searchTerm, int page = 1)
        {
            int pageSize = 5; // records per page

            var query = _context.Products.AsQueryable();

            // SEARCH
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(p =>
                    p.Name.ToLower().Contains(searchTerm.ToLower()) ||
                    p.Category.ToLower().Contains(searchTerm.ToLower()));
            }

            // PAGINATION
            int totalRecords = query.Count();

            var products = query
                .OrderBy(p => p.Name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
            ViewBag.SearchTerm = searchTerm;

            return View(products);
            //    return View(_context.Products.ToList());

        }

        public IActionResult Create()
        {
            var product = new Product
            {
                IsActive = true
            };

            return View(product);
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            bool isDuplicate = _context.Products
            .Any(p => p.Name == product.Name &&
                  p.Category == product.Category);

            if (isDuplicate)
            {
                ModelState.AddModelError("",
                    "Product with the same name and category already exists.");
            }
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            bool isDuplicate = _context.Products
       .Any(p => p.Id != product.Id &&
                 p.Name == product.Name &&
                 p.Category == product.Category);

            if (isDuplicate)
            {
                ModelState.AddModelError("",
                    "Another product with the same name and category already exists.");
            }
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public IActionResult Details(int id)
        {
            return View(_context.Products.Find(id));
        }

        public IActionResult Delete(int id)
        {
            return View(_context.Products.Find(id));
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
