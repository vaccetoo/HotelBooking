
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Infrastructure.Data.Contracts
{
	public abstract class BaseEntity : ISoftDeletable
	{
		[Comment("Unique identifier")]
		[Key]
		public Guid Id { get; set; }

		[Comment("Indicates whether the entity has been deleted or not")]
		[Required]
		public bool IsDeleted { get; set; }

		[Comment("Shows the exact date and time of deletion - optional")]
		public DateTime? DeletedOn { get; set; }
	}
}
