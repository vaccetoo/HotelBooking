using HotelBooking.Core.Contracts;
using HotelBooking.Core.Models;
using HotelBooking.Infrastructure.Data.Contracts;
using HotelBooking.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HotelBooking.Core.Services
{
	public class RoomService : IRoomService
	{
		private readonly IUnitOfWork _unitOfWork;
		private ILogger<RoomService> _logger;

		public RoomService(IUnitOfWork unitOfWork,
			ILogger<RoomService> logger)
		{
			_unitOfWork = unitOfWork;
			_logger = logger;
		}

		public async Task<IEnumerable<RoomListViewModel>> AllAsNoTrackingAsync()
		{
			return await _unitOfWork.AllAsNoTracking<Room>()
				.Select(r => new RoomListViewModel
				{
					Id = r.Id,
					PricePerNight = r.PricePerNight,
					RoomCapacity = r.RoomCapacity,
					RoomNumber = r.RoomNumber,
					Type = r.Type
				})
				.ToListAsync();
		}
	}
}
