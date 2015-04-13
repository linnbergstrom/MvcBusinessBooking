using System.Data.Entity;
using MVCBusinessBooking.Domain.Migrations;
using MVCBusinessBooking.Domain.Models;

namespace MVCBusinessBooking.Domain.Data
{
	public class BusinessBookingContext : DbContext
	{
		public BusinessBookingContext()
			: base("BookingConnectionString")
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<BusinessBookingContext, Configuration>("BookingConnectionString"));
		}

		public DbSet<Restaurant> Restaurants { get; set; }
		public DbSet<Booking> Bookings { get; set; }
		public DbSet<Table> Tables { get; set; }

	}
}