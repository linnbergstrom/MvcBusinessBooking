using System;
using System.Collections.Generic;
using MVCBusinessBooking.Domain.Models;

namespace MVCBusinessBooking.Domain.Migrations
{
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<Data.BusinessBookingContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(Data.BusinessBookingContext context)
		{
			System.Diagnostics.Debug.WriteLine("Seeding...");
			IList<Restaurant> testingRestaurants = new List<Restaurant>();

			string[] cities = { "Luleå", "Piteå", "Gällevare", "Sundsvall", "Malmö", "Fjollträsk" };

			for (int i = 0; i < 5; i++)
			{
				testingRestaurants.Add(new Restaurant
				{
					UserName = "TestUser0" + i,
					Name = "TestName0" + i,
					PhoneNumber = "555-5555" + i,
					Email = "test0" + i + "@testtest.com",
					StreetName = "Rödhakegränd 4",
					City = cities[i],
					Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum",
					MaxCapacity = 55,
					MaxSeatsPerReservation = 10,
					PictureUrl = "",
					OpeningTime = new DateTime(2000, 1, 1, 10, 0, 0),
					ClosingTime = new DateTime(2000, 1, 1, 17, 0, 0),
					Active = true,
					Registered = DateTime.Now
				});
			}
			foreach (Restaurant restaurant in testingRestaurants)
			{
				context.Restaurants.Add(restaurant);
			}
			context.SaveChanges();
			base.Seed(context);
		}
	}
}