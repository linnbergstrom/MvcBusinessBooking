using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using MVCBusinessBooking.Domain.Models;

namespace MVCBusinessBooking.Domain.Interfaces
{
	public interface IBaseRepository<T> where T : class 
	{
		IQueryable<T> GetAll();
		IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
		void Add(T entity);
		void Delete(T entity);
		void Edit(T entity);
		void Save();
	}
}

