using System.Linq;
using MVCBusinessBooking.Domain.Data;
using MVCBusinessBooking.Domain.Interfaces;
using MVCBusinessBooking.Domain.Models;

namespace MVCBusinessBooking.Domain.Repositories
{
	public class BookingRepository : BaseRepository<BusinessBookingContext, Booking>, IBookingRepository
	{
		public Booking GetSingle(int queryId)
		{
			var query = GetAll().FirstOrDefault(x => x.Id == queryId);
			return query;
		}
	}
}