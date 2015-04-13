using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;

namespace MVCBusinessBooking.Domain.Repositories
{
	public abstract class BusinessRepository<TType, TContext>
		where TType : EntityObject
		where TContext : DbContext, new()
	{
		private readonly TContext _context = new TContext();

		protected TContext Context
		{
			get { return _context; }
		}

		public TType Add(TType entity)
		{
			_context.Set<TType>().Add(entity);
			_context.Entry(entity).State = EntityState.Added;
			//_context.AddObject(GetEntitySetName(typeof(TType).Name), entity);
			_context.SaveChanges();
			return entity;
		}

		public virtual bool Delete(TType entity)
		{
			var e = _context.Set<TType>().Attach(entity);
			_context.Entry(e).State = EntityState.Deleted;
			/*_context.AttachTo(GetEntitySetName(typeof(TType).Name), entity);
			_context.ObjectStateManager.ChangeObjectState(entity, EntityState.Deleted);*/
			_context.SaveChanges();
			return true;
		}

		//get by name, id, bookingid
		public TType Get(Expression<Func<TType, bool>> filter)
		{
			return _context.Set<TType>().SingleOrDefault(filter);
			/*return _context.CreateObjectSet<TType>().SingleOrDefault(filter);*/
		}

		public ICollection<TType> GetAll()
		{
			return _context.Set<TType>().ToList();
		}

		public virtual bool Update(TType entity)
		{
			var e = _context.Set<TType>().Attach(entity);
			_context.Entry(e).State = EntityState.Modified;
			_context.SaveChanges();
			/*_context.AttachTo(GetEntitySetName(typeof(TType).Name), entity);
			_context.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
			_context.SaveChanges(SaveOptions.DetectChangesBeforeSave);*/
			return true;
		}

		protected string GetEntitySetName(string entityTypeName)
		{
			return "";
			/*return _context.MetadataWorkspace
				.GetEntityContainer(_context.DefaultContainerName, DataSpace.CSpace)
				.BaseEntitySets
				.Single(x => x.ElementType.Name.Equals(entityTypeName)).Name;*/
		}
	}
}