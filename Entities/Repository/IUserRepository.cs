using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public interface IUserRepository
    {
        IEnumerable<ApplicationUser> GetAllUsers(string userId);
    }
}
