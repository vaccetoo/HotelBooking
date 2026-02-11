using HotelBooking.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HotelBooking.Infrastructure.Data.Constants.ValidationConstants;

namespace HotelBooking.Infrastructure.Data.Models
{
	[Comment("Represents a guest's review of their stay at the hotel")]
	public class Review : BaseEntity
	{
		[MaxLength(CommentMaxLength)]
		[Comment("Text content of the review left by the guest")]
		public string? Comment { get; set; }
		
		[Required]
		[Comment("Rating given by the guest, e.g. 1 to 5 stars")]
		public int Rating { get; set; }
		
		[Required]
		[Comment("Date and time when the review was created")]
		public DateTime CreatedOn { get; set; }


		[Comment("Unique identifier of the guest who created the review")]
		public Guid GuestId { get; set; }

		[DeleteBehavior(DeleteBehavior.Restrict)]
		[ForeignKey(nameof(GuestId))]
		public ApplicationUser Guest { get; set; } = null!;
	}
}
