using MVCBusinessBooking.Domain.Models;

namespace MVCBusinessBooking.Domain.Interfaces
{
	public interface IRestaurantRepository : IBaseRepository<Restaurant>
	{
		Restaurant GetSingle(int id);
	}
}