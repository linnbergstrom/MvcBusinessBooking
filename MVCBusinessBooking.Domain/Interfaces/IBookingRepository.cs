using MVCBusinessBooking.Domain.Models;

namespace MVCBusinessBooking.Domain.Interfaces
{
	public interface IBookingRepository : IBaseRepository<Booking>
	{
		Booking GetSingle(int id);
	}
}