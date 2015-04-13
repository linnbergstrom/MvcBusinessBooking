using System.Web.Optimization;

namespace MVCBusinessBooking
{
	public class BundleConfig
	{
		// For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
		public static void RegisterBundles(BundleCollection bundles)
		{

			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
				"~/Assets/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
				"~/Assets/Scripts/jquery-ui-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Assets/Scripts/jquery.validate*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
				"~/Assets/Scripts/bootstrap.js"));

			bundles.Add(new ScriptBundle("~/bundles/Main").Include(
				"~/Assets/Scripts/Main.js"));

			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
				"~/Assets/Scripts/modernizr-*"));


			bundles.Add(new StyleBundle("~/bundles/css").Include(
				"~/Assets/Content/Site.css",
				"~/Assets/Content/Main.css"));

			bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
				"~/Assets/Content/bootstrap.css"));

			bundles.Add(new StyleBundle("~/bundles/themes/base/css").Include(
				"~/Assets/Content/themes/base/jquery.ui.core.css",
				"~/Assets/Content/themes/base/resizable.css",
				"~/Assets/Content/themes/base/selectable.css",
				"~/Assets/Content/themes/base/accordion.css",
				"~/Assets/Content/themes/base/autocomplete.css",
				"~/Assets/Content/themes/base/button.css",
				"~/Assets/Content/themes/base/dialog.css",
				"~/Assets/Content/themes/base/slider.css",
				"~/Assets/Content/themes/base/tabs.css",
				"~/Assets/Content/themes/base/datepicker.css",
				"~/Assets/Content/themes/base/progressbar.css",
				"~/Assets/Content/themes/base/jquery-ui.theme.css"));
		}
	}
}