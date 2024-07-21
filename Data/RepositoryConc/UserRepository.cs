using Ecommerce.Data.Data;
using Entities.Models;
using Entities.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConc
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository( ApplicationDbContext db)
        {
            _db = db;
        }


        public IEnumerable<ApplicationUser> GetAllUsers(string userId)
        {


            var users = _db.ApplicationUsers.Where(x => x.Id != userId).ToList(); // Get all Users.

            return users;
        }
    }
}
