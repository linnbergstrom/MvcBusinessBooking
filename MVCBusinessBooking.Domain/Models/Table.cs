using System.ComponentModel.DataAnnotations;

namespace MVCBusinessBooking.Domain.Models
{
	public class Table
	{
		[Key]
		public int Id { get; set; }

		public Restaurant Restaurant { get; set; }

		public int Seats { get; set; }

		public int TypeOfTable { get; set; }
	}
}