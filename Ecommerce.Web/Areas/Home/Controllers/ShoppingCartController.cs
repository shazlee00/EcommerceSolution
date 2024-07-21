using Data.RepositoryConc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Ecommerce.Web.Areas.Home.Controllers
{
    [Area("Home")]
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShoppingCartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            string userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            var cart = _unitOfWork.ShoppingCartRepository
                .GetAll(x => x.ApplicationUserId == userId, includeProperties: "Product");

            return View(cart);
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
