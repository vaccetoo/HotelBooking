using HotelBooking.Infrastructure.Data.Configurations;
using HotelBooking.Infrastructure.Data.Extensions;
using HotelBooking.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Infrastructure.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			
		}

		public DbSet<Room> Rooms { get; set; } = null!;
		public DbSet<Facility> Facilities { get; set; } = null!;
		public DbSet<Review> Reviews { get; set; } = null!;
		public DbSet<Reservation> Reservations { get; set; } = null!;
		public DbSet<ReservationFacility> ReservationFacilities { get; set; } = null!;
		public DbSet<Payment> Payments { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplySoftDeleteQueryFilters();
			builder.ApplySeedData();

			base.OnModelCreating(builder);
		}
	}
}
