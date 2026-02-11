using HotelBooking.Infrastructure.Data.Contracts;
using HotelBooking.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HotelBooking.Infrastructure.Data.Constants.ValidationConstants;

namespace HotelBooking.Infrastructure.Data.Models
{
	[Index(nameof(RoomNumber), IsUnique = true)]
	[Comment("Represents a hotel room")]
	public class Room : BaseEntity
	{
		[MaxLength(RoomNumberMaxLength)]
		[Required]
		[Comment("Unique room number within the hotel (e.g. 101, 202A)")]
		public string RoomNumber { get; set; } = null!;

		[Required]
		[Comment("Category/type of the room (e.g. Single, Double, Apartment)")]
		public RoomType Type { get; set; }

		[Required]
		[Comment("Maximum number of guests that can stay in the room")]
		public int RoomCapacity { get; set; }
		
		[Precision(18,2)]
		[Required]
		[Comment("Standard price per night for this room")]
		public decimal PricePerNight { get; set; }


		public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
	}
}
