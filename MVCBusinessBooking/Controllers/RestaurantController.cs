using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBusinessBooking.Domain.Data;
using MVCBusinessBooking.Domain.Models;
using MVCBusinessBooking.Domain.Repositories;
using MVCBusinessBooking.ViewModels;

namespace MVCBusinessBooking.Controllers
{
	public class RestaurantController : Controller
	{
		private readonly RestaurantRepository _restaurangRepository;
		private readonly BookingRepository _bookingRepository;

		public RestaurantController(RestaurantRepository restaurangRepository, BookingRepository bookingRepository)
		{
			_restaurangRepository = restaurangRepository;
			_bookingRepository = bookingRepository;
		}

		public RestaurantController()
		{
			_restaurangRepository = new RestaurantRepository();
		}

		public ActionResult Index()
		{
			var restaurants = _restaurangRepository.GetAll();
			return View(restaurants);
		}

		public ActionResult BookTable(int id)
		{
			ViewBag.Message = "Boka något smarrigt";
			var restaurant = (Restaurant)_restaurangRepository.GetSingle(id);

			if (restaurant != null)
			{
				var latest = restaurant.ClosingTime.AddHours(-2);
				TimeSpan timespan = latest.Subtract(restaurant.OpeningTime);
				int slots = timespan.Hours;
				var currentBookings = restaurant.Bookings.ToList();
				var tables = restaurant.Tables;

				return View(new BookingViewModel
				{
					Business = restaurant,
					Name = restaurant.Name,
				});
			}
			return new HttpNotFoundResult();
		}

		[HttpPost]
		public ActionResult BookTable(BookingViewModel model)
		{
			if (ModelState.IsValid)
			{
				Restaurant restaurant =_restaurangRepository.GetSingle(model.ID);
				restaurant .Bookings.Add(new Booking()
				{
					Email = model.Email,
					Name = model.Name,
					NumberOfPeople = model.NumberOfPeople,
					PhoneNumber = model.PhoneNumber,
					Business = model.Business,
				});
				_restaurangRepository.Edit(restaurant);

				return RedirectToAction("BookingSuccsess");
			}
			return View(model);
		}

		public JsonResult GetAvailableTables(int id, DateTime date, int size)
		{
			//for time = starttime to endtime - 2hr {
			//    if(getBookedTablesCount(id, date, size) < getTotalTables(id, date, size))
			//      timeslots.add(time);
			// }
			var timeslots = new List<string> { "19:00", "20:00", "22:00" };
			return Json(new { timeslots }, JsonRequestBehavior.AllowGet);
		}

		public ActionResult BookingSuccsess()
		{
			return View();
		}
	}
}