using System.Data.Entity;
using System.Data.SqlClient;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MVCBusinessBooking.Domain.Data;

namespace MVCBusinessBooking
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			//this code drops, recreates and seeds database.
			//SqlConnection.ClearAllPools();
			//var context = new EntityFrameworkContext();
			//Database.SetInitializer(new RestaurantDBInitializer());
			//context.Database.Initialize(true);
		}
	}
}