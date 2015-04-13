namespace MVCBusinessBooking.Domain.Models
{
	public class Image
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string AltText { get; set; }

		public string Caption { get; set; }

		public string ImageUrl { get; set; }
	}
}