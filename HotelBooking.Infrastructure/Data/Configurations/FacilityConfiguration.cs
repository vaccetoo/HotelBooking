using HotelBooking.Infrastructure.Data.Enums;
using HotelBooking.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static HotelBooking.Infrastructure.Data.Contracts.SeedConstants;

namespace HotelBooking.Infrastructure.Data.Configurations
{
	internal class FacilityConfiguration : IEntityTypeConfiguration<Facility>
	{
		public void Configure(EntityTypeBuilder<Facility> builder)
		{
			builder.HasData(
				new Facility
				{
					Id = FacilityGymId,
					Type = FacilityType.Gym,
					PricePerDay = 10M,
					OpenAt = GymOpenTime,
					CloseAt = GymCloseTime,
					IsDeleted = false
				},
				new Facility
				{
					Id = FacilitySwimmingPoolId,
					Type = FacilityType.SwimmingPool,
					PricePerDay = 15M,
					OpenAt = SwimmingPoolOpenTime,
					CloseAt = SwimmingPoolCloseTime,
					IsDeleted = false
				});
		}
	}
}
