using Ecommerce.Data.Data;
using Ecommerce.Entities.Models;
using Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConc
{
	public class CategoryRepository: GenericRepository<Category>,ICategoryRepository
	{
		private readonly ApplicationDbContext _db;
		public CategoryRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Update(Category category)
		{
			var objFromDb = _db.Categories.FirstOrDefault(s => s.CategoryId == category.CategoryId);
			if (objFromDb != null)
			{
				objFromDb.Name = category.Name;
				objFromDb.Description= category.Description;
				objFromDb.CreatedTime = DateTime.Now;
			}
		}
	}
}
