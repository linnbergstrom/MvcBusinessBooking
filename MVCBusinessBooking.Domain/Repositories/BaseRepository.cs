using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using MVCBusinessBooking.Domain.Interfaces;

namespace MVCBusinessBooking.Domain.Repositories
{
	public abstract class BaseRepository<C, T> : IBaseRepository<T>
		where T : class where C : DbContext, new()
	{
		public BaseRepository()
		{
			Entities = new C();
		}

		public C Entities { get; set; }

		public virtual IQueryable<T> GetAll()
		{
			IQueryable<T> query = Entities.Set<T>();
			return query;
		}

		public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
		{
			IQueryable<T> query = Entities.Set<T>().Where(predicate);
			return query;
		}

		public virtual void Add(T entity)
		{
			Entities.Set<T>().Add(entity);
		}

		public virtual void Delete(T entity)
		{
			Entities.Set<T>().Remove(entity);
		}

		public virtual void Edit(T entity)
		{
			Entities.Entry(entity).State = EntityState.Modified;
		}

		public virtual void Save()
		{
			Entities.SaveChanges();
		}
	}
}