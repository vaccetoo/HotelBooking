using HotelBooking.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Infrastructure.Data.Services
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _context;

		public UnitOfWork(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task AddAsync<TEntity>(TEntity entity) where TEntity : class
			=> await _context.Set<TEntity>().AddAsync(entity);

		public IQueryable<TEntity> All<TEntity>() where TEntity : class
			=> _context.Set<TEntity>();

		public IQueryable<TEntity> AllAsNoTracking<TEntity>() where TEntity : class
			=> _context.Set<TEntity>().AsNoTracking();

		public async Task<TEntity?> GetByIdAsync<TEntity>(object id) where TEntity : class
			=> await _context.FindAsync<TEntity>(id);

		public async Task<int> SaveChangesAsync()
			=> await _context.SaveChangesAsync();

		public async Task SoftDeleteAsync<TEntity>(object id) where TEntity : class, ISoftDeletable
		{
			var entity = await _context.Set<TEntity>().FindAsync(id);

			if (entity == null)
				return;

			entity.IsDeleted = true;
			entity.DeletedOn = DateTime.UtcNow;
		}
	}
}
