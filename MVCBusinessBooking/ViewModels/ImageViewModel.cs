using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBusinessBooking.Models
{
	public class ImageViewModel
	{
		[Required]
		public string Title
		{
			get;
			set;
		}

		public string AltText
		{
			get;
			set;
		}

		[DataType(DataType.Html)]
		public string Caption
		{
			get;
			set;
		}

		[DataType(DataType.Upload)]
		private HttpPostedFileBase ImageUpload
		{
			get;
			set;
		} //This will hold the posted file data for us.
	}
}