using HotelBooking.Core.Models;

namespace HotelBooking.Core.Contracts
{
	public interface IRoomService
	{
		Task<IEnumerable<RoomListViewModel>> AllAsNoTrackingAsync();
	}
}
