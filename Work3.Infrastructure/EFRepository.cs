using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Work3.Core.Entities;
using Work3.Core.Interfaces;

namespace Work3.Infrastructure
{
	public class EFRepository<T> 
		: IAsyncRepository<T> where T 
		: BaseEntity
	{
		protected readonly StudentContext DbContext;

		public EFRepository(StudentContext dbContext)
		{
			DbContext = dbContext;
		}
		public virtual async Task<T> GetByIdAsync(Guid id)
		{
			return await DbContext.Set<T>().FindAsync(id);
		}

		public async Task<IReadOnlyList<T>> ListAllAsync()
		{
			return await DbContext.Set<T>().ToListAsync();
		}

		public async Task<T> AddAsync(T entity)
		{
			DbContext.Set<T>().Add(entity);
			await DbContext.SaveChangesAsync();
			return entity;
		}
	}
}
