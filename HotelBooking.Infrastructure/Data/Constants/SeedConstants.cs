namespace HotelBooking.Infrastructure.Data.Contracts
{
	internal static class SeedConstants
	{
		internal static readonly Guid Room101Id = Guid.Parse("00000000-0000-0000-0000-000000000001");
		internal static readonly Guid Room102Id = Guid.Parse("00000000-0000-0000-0000-000000000002");

		internal static readonly Guid FacilityGymId = Guid.Parse("00000000-0000-0000-0000-000000000011");
		internal static readonly Guid FacilitySwimmingPoolId = Guid.Parse("00000000-0000-0000-0000-000000000012");

		internal static readonly TimeOnly GymOpenTime = TimeOnly.Parse("08:00");
		internal static readonly TimeOnly GymCloseTime = TimeOnly.Parse("22:00");

		internal static readonly TimeOnly SwimmingPoolOpenTime = TimeOnly.Parse("08:00");
		internal static readonly TimeOnly SwimmingPoolCloseTime = TimeOnly.Parse("20:00");

		internal static readonly Guid ReviewId = Guid.Parse("00000000-0000-0000-0000-000000000013");

		internal static readonly DateTime ReviewCreatedOn = DateTime.Parse("2025-02-11 14:30:00");

		internal static readonly Guid ReservationId = Guid.Parse("00000000-0000-0000-0000-000000000014");

		internal static readonly DateOnly ConstCheckInDate = DateOnly.Parse("2025-03-01");
		internal static readonly DateOnly ConstCheckOutDate = DateOnly.Parse("2025-03-03");

		internal static readonly Guid PaymentId = Guid.Parse("00000000-0000-0000-0000-000000000015");
		internal static readonly DateTime PaymentCreatedOn = DateTime.Parse("2025-01-15 14:30:00");

		public static readonly Guid AdminId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");

	}
}
