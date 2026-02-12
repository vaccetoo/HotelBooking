using HotelBooking.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static HotelBooking.Infrastructure.Data.Contracts.SeedConstants;

namespace HotelBooking.Infrastructure.Data.Configurations
{
	internal class ReservationFacilityConfiguration : IEntityTypeConfiguration<ReservationFacility>
	{
		public void Configure(EntityTypeBuilder<ReservationFacility> builder)
		{
			builder.HasQueryFilter(rf => !rf.Facility.IsDeleted);

			builder.HasData(
				new ReservationFacility
				{
					ReservationId = ReservationId,
					FacilityId = FacilitySwimmingPoolId
				});
		}
	}
}
