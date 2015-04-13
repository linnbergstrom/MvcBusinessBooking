using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using MVCBusinessBooking.Domain.Models;

namespace MVCBusinessBooking.ViewModels
{
	public class RestaurantViewModel
	{
		private List<Table> _tables;

		public RestaurantViewModel()
		{
		}

		public RestaurantViewModel(Business restaurant)
		{
			Id = restaurant.Id;
			UserName = restaurant.UserName;
			Name = restaurant.Name;
			PhoneNumber = restaurant.PhoneNumber;
			Email = restaurant.Email;
			StreetName = restaurant.StreetName;
			City = restaurant.City;
			Description = restaurant.Description;
			MaxCapacity = restaurant.MaxCapacity;
			MaxSeatsPerReservation = restaurant.MaxSeatsPerReservation;
			PictureUrl = restaurant.PictureUrl;
			OpeningTime = restaurant.OpeningTime;
			ClosingTime = restaurant.ClosingTime;
			Active = restaurant.Active;
			Registered = DateTime.Now;
		}

		public bool Active { get; set; }

		[Required(ErrorMessage = "Please add a city")]
		public string City { get; set; }

		//public List<Table> Tables { get; set; }
		public IEnumerable<DateTime> ClosedDates { get; set; }

		[Required(ErrorMessage = "Please add your closing hours")]
		[DataType(DataType.Time)]
		public DateTime ClosingTime { get; set; }

		public string Description { get; set; }

		[Range(0, 20)]
		public int EightSeat { get; set; }

		[Required(ErrorMessage = "Please add an email address")]
		[RegularExpression(
			@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
			ErrorMessage = "The email address is not correct")]
		public string Email { get; set; }

		[Range(0, 20)]
		public int FourSeat { get; set; }

		public int Id { get; set; }

		[DataType(DataType.Upload)]
		public HttpPostedFileBase ImageUpload { get; set; }

		[Required(ErrorMessage = "Please add your maximum capacity")]
		public int MaxCapacity { get; set; }

		[Required(ErrorMessage = "Please add your maximum limit of seats per reservation")]
		public int MaxSeatsPerReservation { get; set; }

		[Required(ErrorMessage = "Please write the name of your restaurant")]
		public string Name { get; set; }

		[Range(0, 20)]
		public int OneSeat { get; set; }

		[Required(ErrorMessage = "Please add your opening hours")]
		[DataType(DataType.Time)]
		public DateTime OpeningTime { get; set; }

		[Required(ErrorMessage = "Please add a phone number")]
		[RegularExpression(@"^[0-9+\(\)#\.\s\/ext-]+$",
			ErrorMessage = "The phone number is not correct")]
		public string PhoneNumber { get; set; }

		public string PictureUrl { get; set; }

		// max antal platser per bokning
		//This will hold the posted file data for us.
		public DateTime Registered { get; set; }

		[Range(0, 20)]
		public int SixSeat { get; set; }

		[Required(ErrorMessage = "Please add a street name")]
		public string StreetName { get; set; }

		//antalet platser i restaurang
		[Range(0, 20)]
		public int TwoSeat { get; set; }

		public string UserName { get; set; }

		public Restaurant ToDomainModel(Restaurant restaurant)
		{
			_tables = new List<Table>();
			restaurant.Name = Name;
			restaurant.UserName = UserName;
			restaurant.PhoneNumber = PhoneNumber;
			restaurant.Email = Email;
			restaurant.StreetName = StreetName;
			restaurant.City = City;
			restaurant.Description = Description;
			restaurant.MaxCapacity = MaxCapacity;
			restaurant.MaxSeatsPerReservation = MaxSeatsPerReservation;
			restaurant.PictureUrl = PictureUrl;
			restaurant.OpeningTime = OpeningTime;
			restaurant.ClosingTime = ClosingTime;
			restaurant.Active = Active;
			restaurant.Registered = DateTime.Now;

			AddTables(1, OneSeat, restaurant);
			AddTables(2, TwoSeat, restaurant);
			AddTables(4, FourSeat, restaurant);
			AddTables(6, SixSeat, restaurant);
			AddTables(8, EightSeat, restaurant);

			restaurant.Tables = _tables;
			return restaurant;
		}

		private void AddTables(int tableType, int seats, Restaurant restaurant)
		{
			if (seats == 0)
				return;
			var i = 0;
			while (i < seats)
			{
				var table = new Table
				{
					TypeOfTable = tableType,
					Seats = seats,
					Restaurant = restaurant
				};
				_tables.Add(table);
				i++;
			}
		}
	}
}