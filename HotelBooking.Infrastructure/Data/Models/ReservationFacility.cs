using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Infrastructure.Data.Models
{
	[PrimaryKey(nameof(ReservationId), nameof(FacilityId))]
	[Comment("Join table representing the many-to-many relationship between Reservations and Facilities")]
	public class ReservationFacility
	{
		[Comment("Unique identifier of the reservation")]
		public Guid ReservationId { get; set; }

		[DeleteBehavior(DeleteBehavior.Restrict)]
		[ForeignKey(nameof(ReservationId))]
		public Reservation Reservation { get; set; } = null!;

		[Comment("Unique identifier of the facility")]
		public Guid FacilityId { get; set; }

		[DeleteBehavior(DeleteBehavior.Restrict)]
		[ForeignKey(nameof(FacilityId))]
		public Facility Facility { get; set; } = null!;
	}
}
