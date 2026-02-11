using HotelBooking.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBooking.Infrastructure.Data.Configurations
{
	internal class ReservationFacilitiesConfiguration : IEntityTypeConfiguration<ReservationFacility>
	{
		public void Configure(EntityTypeBuilder<ReservationFacility> builder)
		{
			builder.HasQueryFilter(rf => !rf.Facility.IsDeleted);
		}
	}
}
