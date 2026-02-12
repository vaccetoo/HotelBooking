using HotelBooking.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static HotelBooking.Infrastructure.Data.Contracts.SeedConstants;

namespace HotelBooking.Infrastructure.Data.Configurations
{
	internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			var hasher = new PasswordHasher<ApplicationUser>();

			var admin = new ApplicationUser
			{
				Id = AdminId,
				UserName = "admin@hotel.com",
				NormalizedUserName = "ADMIN@HOTEL.COM",
				Email = "admin@hotel.com",
				NormalizedEmail = "ADMIN@HOTEL.COM",
				EmailConfirmed = true,
				SecurityStamp = "STATIC_SECURITY_STAMP",
				ConcurrencyStamp = "STATIC_CONCURRENCY_STAMP"
			};

			admin.PasswordHash = hasher.HashPassword(admin, "Admin123!");

			builder.HasData(admin);
		}
	}
}
