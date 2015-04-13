using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBusinessBooking.Domain.Models;
using MVCBusinessBooking.Domain.Repositories;

namespace MVCBusinessBooking.Controllers
{
	public class HomeController : Controller
	{
		private readonly RestaurantRepository _restaurangRepository;

		public HomeController()
		{
			_restaurangRepository = new RestaurantRepository();
		}

		// GET: Home
		public ActionResult Index()
		{
			var restaurants = _restaurangRepository.GetAll();
			return View(restaurants);
		}

		public ActionResult About()
		{
			ViewBag.Message = "We love food!";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}