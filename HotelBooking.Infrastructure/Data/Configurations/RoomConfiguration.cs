using HotelBooking.Infrastructure.Data.Enums;
using HotelBooking.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static HotelBooking.Infrastructure.Data.Contracts.SeedConstants;

namespace HotelBooking.Infrastructure.Data.Configurations
{
	internal class RoomConfiguration : IEntityTypeConfiguration<Room>
	{
		public void Configure(EntityTypeBuilder<Room> builder)
		{
			builder.HasData(
				new Room
				{
					Id = Room101Id,
					RoomNumber = "101",
					Type = RoomType.SingleRoom,
					RoomCapacity = 1,
					PricePerNight = 50M,
					IsDeleted = false
				},
				new Room
				{
					Id = Room102Id,
					RoomNumber = "102",
					Type = RoomType.DoubleRoom,
					RoomCapacity = 2,
					PricePerNight = 90M,
					IsDeleted = false
				});
		}
	}
}

