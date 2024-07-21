using Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConc
{
	public interface IUnitOfWork
	{
		ICategoryRepository CategoryRepository { get; }

		IProductRepository ProductRepository { get; }

		IShoppingCartRepository ShoppingCartRepository { get; }

		int save();
		void Dispose();
	}
}
