using HotelBooking.Infrastructure.Data.Contracts;
using HotelBooking.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Infrastructure.Data.Models
{
	[Comment("Represents a payment made for a reservation")]
	public class Payment : BaseEntity
	{
		[Precision(18, 2)]
		[Required]
		[Comment("Amount paid in the transaction")]
		public decimal Amount { get; set; }

		[Required]
		[Comment("Status of the payment (e.g., Pending, Completed, Failed)")]
		public PaymentStatus Status { get; set; }

		[Required]
		[Comment("Date and time when the payment was created")]
		public DateTime CreatedOn { get; set; }


		[Comment("Unique identifier of the reservation associated with this payment")]
		public Guid ReservationId { get; set; }

		[DeleteBehavior(DeleteBehavior.Restrict)]
		[ForeignKey(nameof(ReservationId))]
		public Reservation Reservation { get; set; } = null!;
	}
}
