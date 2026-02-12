using HotelBooking.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static HotelBooking.Infrastructure.Data.Contracts.SeedConstants;
using HotelBooking.Infrastructure.Data.Enums;

namespace HotelBooking.Infrastructure.Data.Configurations
{
	internal class PaymentConfiguration : IEntityTypeConfiguration<Payment>
	{
		public void Configure(EntityTypeBuilder<Payment> builder)
		{
			builder.HasData(
				new Payment
				{
					Id = PaymentId,
					Amount = 80M,
					CreatedOn = PaymentCreatedOn,
					ReservationId = ReservationId,
					Status = PaymentStatus.Paid,
					IsDeleted = false
				});
		}
	}
}
