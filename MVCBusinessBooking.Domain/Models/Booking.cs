using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;

namespace MVCBusinessBooking.Domain.Models
{
	public class Booking //eller bokning, eller kund?
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }

		public int PhoneNumber { get; set; }

		public string Email { get; set; }

		public int NumberOfPeople { get; set; }

		public Business Business { get; set; }
	}
}