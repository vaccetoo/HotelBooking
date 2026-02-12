using HotelBooking.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static HotelBooking.Infrastructure.Data.Contracts.SeedConstants;

namespace HotelBooking.Infrastructure.Data.Configurations
{
	internal class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
	{
		public void Configure(EntityTypeBuilder<Reservation> builder)
		{
			builder.HasData(new Reservation
			{
				Id = ReservationId,
				GuestId = AdminId,
				RoomId = Room101Id,
				CheckInDate = ConstCheckInDate,
				CheckOutDate = ConstCheckOutDate,
				Nights = 2,
				TotalPrice = 80M,
				IsDeleted = false
			});
		}
	}
}
