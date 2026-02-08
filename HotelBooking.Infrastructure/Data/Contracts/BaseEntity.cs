
namespace HotelBooking.Infrastructure.Data.Contracts
{
	public abstract class BaseEntity : ISoftDeletable
	{
		public Guid Id { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime? DeletedOn { get; set; }
	}
}
