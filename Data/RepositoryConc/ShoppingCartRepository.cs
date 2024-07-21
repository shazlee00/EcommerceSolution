using Ecommerce.Data.Data;
using Ecommerce.Entities.Models;
using Entities.Models;
using Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConc
{
	public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
		private readonly ApplicationDbContext _db;
		public ShoppingCartRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

        public void Decrease(ShoppingCart shoppingCart, int count)
        {
            throw new NotImplementedException();
        }

        public void Increase(ShoppingCart shoppingCart, int count)
        {
            _db.ShoppingCarts.FirstOrDefault(x => x.ShoppingCartId == shoppingCart.ShoppingCartId).Quantity += count;
            _db.SaveChanges();
        }
    }
}
