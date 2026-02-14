using HotelBooking.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Core.Models
{
	public class RoomListViewModel
	{
		public Guid Id { get; set; }

		public string RoomNumber { get; set; } = null!;

		public RoomType Type { get; set; }

		public int RoomCapacity { get; set; }

		public decimal PricePerNight { get; set; }
	}
}
