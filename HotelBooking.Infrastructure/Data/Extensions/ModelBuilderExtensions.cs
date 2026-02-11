using HotelBooking.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HotelBooking.Infrastructure.Data.Extensions
{
	public static class ModelBuilderExtensions
	{
		public static void ApplySoftDeleteQueryFilters(this ModelBuilder modelBuilder)
		{
			foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			{
				if (typeof(ISoftDeletable).IsAssignableFrom(entityType.ClrType))
				{
					var method = typeof(ModelBuilderExtensions)
								.GetMethod(nameof(SetSoftDeleteFilter), 
								BindingFlags.NonPublic | BindingFlags.Static)
								?? throw new InvalidOperationException("SetSoftDeleteFilter method not found");

					method.MakeGenericMethod(entityType.ClrType).Invoke(null, new object[] { modelBuilder });
				}
			}
		}

		private static void SetSoftDeleteFilter<TEntity>(ModelBuilder builder)
			where TEntity : class, ISoftDeletable
		{
			builder.Entity<TEntity>()
				   .HasQueryFilter(e => !e.IsDeleted);
		}
	}
}
