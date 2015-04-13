using System.Linq;
using MVCBusinessBooking.Domain.Data;
using MVCBusinessBooking.Domain.Interfaces;
using MVCBusinessBooking.Domain.Models;

namespace MVCBusinessBooking.Domain.Repositories
{
	public class RestaurantRepository : BaseRepository<BusinessBookingContext, Restaurant>, IRestaurantRepository
	{
		public Restaurant GetSingle(int queryId)
		{
			var query = GetAll().FirstOrDefault(x => x.Id == queryId);
			return query;
		}
	}
}