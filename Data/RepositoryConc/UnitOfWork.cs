using Ecommerce.Data.Data;
using Entities.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConc
{
	public class UnitOfWork : IUnitOfWork
	{
		public ICategoryRepository CategoryRepository {get; private set;}

		public IProductRepository ProductRepository { get; private set;}

		public IShoppingCartRepository ShoppingCartRepository {  get; private set;}

		private ApplicationDbContext _db;
		public UnitOfWork(ApplicationDbContext db)
		{
			_db = db;
			CategoryRepository=new CategoryRepository(db);
			ProductRepository=new ProductRepository(db);
            ShoppingCartRepository = new ShoppingCartRepository(db);
		}

		public void Dispose()
		{
          _db.Dispose();
		}

		public int save()
		{
			_db.ChangeTracker.DetectChanges();
			// _context.SaveChanges();
			Console.WriteLine("After:" + _db.ChangeTracker.DebugView.ShortView);
			return _db.SaveChanges();
		}
	}
}
