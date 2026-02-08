namespace HotelBooking.Infrastructure.Data.Contracts
{
	public interface ISoftDeletable
	{
		bool IsDeleted { get; set; }
		DateTime? DeletedOn { get; set; }
	}
}
