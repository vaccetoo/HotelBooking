using HotelBooking.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Infrastructure.Data.Models
{
	[Comment("Represents a reservation made by a guest for a specific room")]
	public class Reservation : BaseEntity
	{
		[Precision(18, 2)]
		[Required]
		[Comment("Total price of the reservation including all nights and additional facilities")]
		public decimal TotalPrice { get; set; }

		[Comment("Check-in date for the reservation")]
		public DateOnly CheckInDate { get; set; }

		[Comment("Check-out date for the reservation")]
		public DateOnly CheckOutDate { get; set; }

		[Comment("Number of nights between check-in and check-out")]
		public int Nights { get; set; }


		[Comment("Unique identifier of the guest who made the reservation")]
		public Guid GuestId { get; set; }

		[DeleteBehavior(DeleteBehavior.Restrict)]
		[ForeignKey(nameof(GuestId))]
		public ApplicationUser Guest { get; set; } = null!;

		[Comment("Unique identifier of the reserved room")]
		public Guid RoomId { get; set; }

		[DeleteBehavior(DeleteBehavior.Restrict)]
		[ForeignKey(nameof(RoomId))]
		public Room Room { get; set; } = null!;

		public ICollection<ReservationFacility> ReservationFacilities { get; set; } = new List<ReservationFacility>();
	}
}
