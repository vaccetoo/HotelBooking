using HotelBooking.Infrastructure.Data.Contracts;
using HotelBooking.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Infrastructure.Data.Models
{
	[Comment("Represents facility in the hotel")]
	public class Facility : BaseEntity
	{
		[Required]
		[Comment("Facility type (e.g. Gym, Swimming pool, Conference room)")]
		public FacilityType Type { get; set; }

		[Precision(18, 2)]
		[Required]
		[Comment("Standard price per day for using the facility")]
		public decimal PricePerDay { get; set; }
		
		[Required]
		[Comment("Shows what time the facility opens")]
		public TimeOnly OpenAt { get; set; }
		
		[Required]
		[Comment("Shows what time the facility closes")]
		public TimeOnly CloseAt { get; set; } 


		public ICollection<ReservationFacility> ReservationFacilities { get; set; } = new List<ReservationFacility>();	
	}
}
