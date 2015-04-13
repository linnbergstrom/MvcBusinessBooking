using System.Collections.Generic;

namespace MVCBusinessBooking.Domain.Models
{
	public class Restaurant : Business
	{
		public List<Table> Tables { get; set; } //if I dont need a specific type, there is no need to specify.
	}
}