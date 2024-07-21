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
	public class ProductRepository: GenericRepository<Product>,IProductRepository
	{
		private readonly ApplicationDbContext _db;
		public ProductRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Update(Product procut)
		{
			var objFromDb = _db.Products.FirstOrDefault(s => s.Id == procut.Id);
			if (objFromDb != null)
			{
				objFromDb.Name = procut.Name;
				objFromDb.Description = procut.Description;
				objFromDb.Price = procut.Price;
				objFromDb.Img = procut.Img;
				objFromDb.CategoryId = procut.CategoryId;
			}
		}
	}
}
