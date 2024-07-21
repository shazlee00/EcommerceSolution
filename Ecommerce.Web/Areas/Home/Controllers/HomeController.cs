using Data.RepositoryConc;
using Ecommerce.Web.Areas.Home.Models;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Ecommerce.Web.Areas.Home.Controllers
{
    [Area("Home")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var data = _unitOfWork.ProductRepository.GetAll(includeProperties:"Category").Select
                (
    x => new HomeVM
    {
        Id = x.Id,
        Name=x.Name,
        Description=x.Description,
        Price=x.Price,
        Img=x.Img,
        Category= x.Category.Name
    });
            return View(data);
        }



        public IActionResult Details(int id)
        {
            var data = _unitOfWork.ProductRepository.Get(x => x.Id == id, includeProperties: "Category");

            var detailsVM = new DetailsVM()
            {
                ProductId = data.Id,
                ProductName = data.Name,
                Description = data.Description,
                Price = data.Price,
                Img = data.Img,
                Category = data.Category.Name
            };

            return View(detailsVM);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [Authorize]
        public IActionResult AddToCart(DetailsVM details)
        {
            var cart = new ShoppingCart()
            {
                ProductId = details.ProductId,
                Quantity = details.CartCount
            };
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            string userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            var cartItem = _unitOfWork.ShoppingCartRepository
                .Get(x => x.ProductId == cart.ProductId && x.ApplicationUserId == userId);
            if (cartItem == null)
            {
                cart.ApplicationUserId = userId;
                _unitOfWork.ShoppingCartRepository.Add(cart);
                
            }
            else
            {
                _unitOfWork.ShoppingCartRepository.Increase(cartItem, cart.Quantity);
            }

            
            _unitOfWork.save();

            return RedirectToAction(nameof(Index));
        }

    }

}
