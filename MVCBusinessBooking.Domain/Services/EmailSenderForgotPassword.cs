using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBusinessBooking.Domain.Models;
using MVCBusinessBooking.Domain.Services;

namespace MVCBusinessBooking.Infrastructure
{
	public class EmailSenderForgotPassword : IEmailHandler
	{
		public void SendEmail(Email email)
		{
			throw new NotImplementedException();
		}
	}
}