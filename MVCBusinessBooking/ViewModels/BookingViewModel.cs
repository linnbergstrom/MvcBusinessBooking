using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MVCBusinessBooking.Domain.Models;

namespace MVCBusinessBooking.ViewModels
{
	public class BookingViewModel
	{
		[Key]
		public int ID { get; set; }

		public IList<Booking> Bookings { get; set; }

		public string BusinessName { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		public DateTime Date { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		public Business Business { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		[Range(1, 100)]
		public int NumberOfPeople { get; set; }

		[Required]
		public int PhoneNumber { get; set; }

		public int Timeslots { get; set; }
	}
}