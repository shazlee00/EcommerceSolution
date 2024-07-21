using Ecommerce.Data.Data;
using Entities.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Utils;

namespace Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles = SD.AdminRole)]
	public class UsersController : Controller
    {
        private readonly  IUserRepository  _userRepository;

        public UsersController( IUserRepository userRepository)
        {
           _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            var claimsIdentity= (ClaimsIdentity)User.Identity;
            string userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

           var users= _userRepository.GetAllUsers(userId); // Get all Users.

            return View(users);
        }
    }
}
