using Data.RepositoryConc;
using Ecommerce.Data.Data;
using Ecommerce.Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Utils;

namespace Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]

    [Authorize(Roles =SD.AdminRole)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            var categories = unitOfWork.CategoryRepository.GetAll();
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
                //_context.categories.Add(category);
                //_context.SaveChanges();
                unitOfWork.CategoryRepository.Add(category);
                unitOfWork.save();
                TempData["SuccessMessage"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //var category = _context.categories.Find(id);
            var category = unitOfWork.CategoryRepository.Get(x => x.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                //var cat = _context.categories.Find(category.CategoryId);
                //cat.Name = category.Name;
                //cat.Description = category.Description;
                //_context.SaveChanges();
                unitOfWork.CategoryRepository.Update(category);
                unitOfWork.save();
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
            //var category = _context.categories.Find(id);
            var category = unitOfWork.CategoryRepository.Get(x => x.CategoryId == id);
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
            //var category = _context.categories.Find(id);
            var category = unitOfWork.CategoryRepository.Get(x => x.CategoryId == id);
            if (category == null)
            {
                return Content("Category not found"); // Return an error message or redirect to an error page();
            }

            //_context.categories.Remove(category);
            //_context.SaveChanges();

            unitOfWork.CategoryRepository.Delete(id);
            unitOfWork.save();

            TempData["SuccessMessage"] = "Category deleted successfully";

            return RedirectToAction(nameof(Index)); // Redirect to the index or a relevant page
        }



    }
}
