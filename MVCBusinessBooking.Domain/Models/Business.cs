using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;

namespace MVCBusinessBooking.Domain.Models
{
	public abstract class Business 
	{
		[Key]
		public int Id { get; set; }

		public string UserName { get; set; }

		public string Name { get; set; }

		public string PhoneNumber { get; set; }

		public string Email { get; set; }

		public string StreetName { get; set; }

		public string City { get; set; }

		public string Description { get; set; }

		public int MaxCapacity { get; set; } //antalet platser i restaurang

		public int MaxSeatsPerReservation { get; set; } // max antal platser per bokning

		public string PictureUrl { get; set; }

		public DateTime OpeningTime { get; set; }

		public DateTime ClosingTime { get; set; }

		public bool Active { get; set; }

		public DateTime Registered { get; set; }

		public virtual IList<Booking> Bookings { get; set; }
	}
}