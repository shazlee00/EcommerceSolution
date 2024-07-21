using Data.RepositoryConc;
using Ecommerce.Entities.Models;
using Ecommerce.Web.Areas.Admin.Models;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Utils;

namespace Ecommerce.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = SD.AdminRole)]
	public class ProductController : Controller
    {
		private readonly IUnitOfWork unitOfWork;

		public ProductController(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}


		public IActionResult Index()
		{
			return View();
		}
		public IActionResult GetProducts()
		{
			var products = unitOfWork.ProductRepository.GetAll(includeProperties:"Category");
			return Json(new { 
        data = products.Select(x => new
				{
					id = x.Id,
					name = x.Name,
					description = x.Description,
					price = x.Price,
					img = x.Img,
					category = x.Category.Name
				})
			
			});
		}

		[HttpGet]
		public IActionResult Create()
		{
			ProductVM productVM = new ProductVM();

			productVM.Categories=unitOfWork.CategoryRepository.GetAll().Select(x => new SelectListItem
			{
				Text = x.Name,
				Value = x.CategoryId.ToString()
			});

			return View(productVM);
		}

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Create(ProductVM productVM, IFormFile Img)
		{
			if (ModelState.IsValid)
			{
				if (Img!= null)
				{
					string uploadsFolder = Path.Combine("wwwroot","uploads","products");
					Directory.CreateDirectory(uploadsFolder); 

					var filePath = Path.Combine(uploadsFolder,Path.GetRandomFileName() + "_" + Img.FileName);


					using (var stream = System.IO.File.Create(filePath))
					{
						Img.CopyTo(stream);
						productVM.Img = filePath.Split("wwwroot")[1];
					}
					
				}
				//_context.categories.Add(product);
				//_context.SaveChanges();
				unitOfWork.ProductRepository.Add(
					new Product
					{
						Name = productVM.Name,
						Description = productVM.Description,
						Price = productVM.Price,
						Img = Img != null ? productVM.Img : null,
						CategoryId = productVM.CategoryId
					}
					);
				unitOfWork.save();
				TempData["SuccessMessage"] = "Product created successfully";
				return RedirectToAction("Index");
			}
			else
			{
				return View(productVM);
			}

		}
		[HttpGet]
		public IActionResult Edit(int id)
		{
			var product = unitOfWork.ProductRepository.Get(x => x.Id == id);
			ProductVM productVM = new ProductVM()
			{
				Id = product.Id,
				Name = product.Name,
				Description = product.Description,
				Price = product.Price,
				Img = product.Img,
				CategoryId = product.CategoryId
			};

			productVM.Categories = unitOfWork.CategoryRepository.GetAll().Select(x => new SelectListItem
			{
				Text = x.Name,
				Value = x.CategoryId.ToString()
			});
			return View(productVM);
		}

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Edit(ProductVM productVM , IFormFile? Img)
		{
			if (ModelState.IsValid)
			{
				//var cat = _context.categories.Find(product.ProductId);
				//cat.Name = product.Name;
				//cat.Description = product.Description;
				//_context.SaveChanges();
				if (Img != null)
				{
					string uploadsFolder = Path.Combine("wwwroot", "uploads", "products");
					Directory.CreateDirectory(uploadsFolder);
					var filePath = Path.Combine(uploadsFolder, Path.GetRandomFileName() + "_" + Img.FileName);

					//if(productVM.Img != null)
					//{
					//	System.IO.File.Delete(Path.Combine(RootPath,"wwwroot",productVM.Img));
					//}

					using (var stream = System.IO.File.Create(filePath))
					{
						Img.CopyTo(stream);
						productVM.Img = filePath.Split("wwwroot")[1];
					}

				}

				var product = new Product
				{
					Id = productVM.Id,
					Name = productVM.Name,
					Description = productVM.Description,
					Price = productVM.Price,
					Img = productVM.Img,
					CategoryId = productVM.CategoryId
				};
				unitOfWork.ProductRepository.Update(product);
				unitOfWork.save();
				TempData["SuccessMessage"] = "Product Edited successfully";
				return RedirectToAction("Index");
			}
			else
			{
				return View(productVM);
			}

		}

		[HttpDelete]
		public IActionResult Delete(int id)
		{
			//var product = _context.categories.Find(id);
			var product = unitOfWork.ProductRepository.Get(x => x.Id == id);
			if (product == null)
			{
				return Json(new { success = false, message = "Product not found" });
			}
			unitOfWork.ProductRepository.Delete(id);
			unitOfWork.save();
			return Json(new { success = true, message = "Product deleted successfully" });
		}

	}
}
