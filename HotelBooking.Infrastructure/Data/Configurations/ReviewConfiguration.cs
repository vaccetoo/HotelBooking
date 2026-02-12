using HotelBooking.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static HotelBooking.Infrastructure.Data.Contracts.SeedConstants;

namespace HotelBooking.Infrastructure.Data.Configurations
{
	internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
	{
		public void Configure(EntityTypeBuilder<Review> builder)
		{
			builder.HasData(
				new Review()
				{
					Id = ReviewId,
					Comment = null,
					CreatedOn = ReviewCreatedOn,
					Rating = 4,
					GuestId = AdminId,
					IsDeleted = false
				});
		}
	}
}
