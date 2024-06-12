using Ecommerce.Web.Data;
using Ecommerce.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _context;

		public CategoryController(ApplicationDbContext context)
		{
			_context = context;
		}
		
		
		public IActionResult Index()
		{
			var categories = _context.categories.ToList();
			return View(categories);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Category category)
		{
			if (ModelState.IsValid)
			{
				_context.categories.Add(category);
				_context.SaveChanges();
				return RedirectToAction("Index");
			} else
			{
				return View(category);
			}
			
		}


	}
}
