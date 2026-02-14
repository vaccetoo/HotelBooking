using HotelBooking.Core.Contracts;
using HotelBooking.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Web.Controllers
{
	public class RoomController : Controller
	{
		private readonly IRoomService _roomService;

		public RoomController(IRoomService roomService)
		{
			_roomService = roomService;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			IEnumerable<RoomListViewModel> model =
					await _roomService.AllAsNoTrackingAsync();

			return View(model);
		}
	}
}
