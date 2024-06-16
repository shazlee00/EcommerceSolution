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
		[AutoValidateAntiforgeryToken]
		public IActionResult Create(Category category)
		{
			if (ModelState.IsValid)
			{
				_context.categories.Add(category);
				_context.SaveChanges();
				TempData["SuccessMessage"] = "Category created successfully";
				return RedirectToAction("Index");
			} else
			{
				return View(category);
			}
			
		}
		[HttpGet]
		public IActionResult Edit(int id)
		{
			return View(_context.categories.Find(id));
		}

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Edit(Category category)
		{
			if (ModelState.IsValid)
			{
				var cat = _context.categories.Find(category.CategoryId);
				cat.Name = category.Name;
				cat.Description = category.Description;
				_context.SaveChanges();
				TempData["SuccessMessage"] = "Category Edited successfully";
				return RedirectToAction("Index");
			} 
			else
			{
				return View(category);
			}
			
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			var category = _context.categories.Find(id);
			if (category == null)
			{
				return NotFound();
			}
			return View(category); // This view should prompt for deletion confirmation
		}


		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(int id)
		{
			var category = _context.categories.Find(id);
			if (category == null)
			{
				return Content("Category not found"); // Return an error message or redirect to an error page();
			}

			_context.categories.Remove(category);
			_context.SaveChanges();

			TempData["SuccessMessage"] = "Category deleted successfully";

			return RedirectToAction(nameof(Index)); // Redirect to the index or a relevant page
		}



	}
}
