using HotelBooking.Infrastructure.Data.Enums;
using System.ComponentModel;

namespace HotelBooking.Core.Models
{
	public class RoomListViewModel
	{
		public Guid Id { get; set; }

		[DisplayName("Room number")]
		public string RoomNumber { get; set; } = null!;	

		public RoomType Type { get; set; }

		[DisplayName("Capacity")]
		public int RoomCapacity { get; set; }

		[DisplayName("Price per night")]
		public decimal PricePerNight { get; set; }
	}
}
