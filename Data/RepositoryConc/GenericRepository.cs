using Ecommerce.Data.Data;
using Entities.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConc
{
	public class GenericRepository<T> : IGRepository<T> where T : class
	{
		private readonly ApplicationDbContext _db;

		private DbSet<T> _dbSet;

		public GenericRepository(ApplicationDbContext db)
		{
			_db = db;
			_dbSet = _db.Set<T>();
		}

		public void Add(T entity)
		{
			_dbSet.Add(entity);
		}

		public void Delete(int id)
		{
			_dbSet.Remove(_dbSet.Find(id));
		}

		public T Get(Expression<Func<T, bool>> predicate = null,params string[] includeProperties)
		{
			if (includeProperties != null)
			{
				IQueryable<T> query = _dbSet;
				foreach (var includeProperty in includeProperties)
				{
					query = query.Include(includeProperty);
				}
				return query.FirstOrDefault(predicate);
			}
			else
			{
				return _dbSet.FirstOrDefault();
			}
		}
		public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null, string includeProperties = null)
		{
            IQueryable<T> query = _dbSet;
			if (predicate != null)
			{
				query = query.Where(predicate);
			}
			if (includeProperties != null)
			{
				foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProperty);
				}
			}
			return query.ToList();
		}

	}
}
