using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
	public interface IGRepository<T> where T : class
	{
		IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null ,string includeProperties = null); // string includeProperties = null);
		T Get(Expression<Func<T, bool>> predicate = null, params string[] includeProperties);
		void Add(T entity);
		void Delete(int id);
	}
}
