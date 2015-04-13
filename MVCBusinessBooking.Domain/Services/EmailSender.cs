using System.Configuration;
using System.Net;
using System.Net.Mail;
using MVCBusinessBooking.Domain.Models;

namespace MVCBusinessBooking.Models
{
	public class EmailSender
	{
		public static void CreateEmailMessage(string template, string emailSubject, string emailrecipicent)
		{
			var email = new Email
			{
				userId = ConfigurationManager.AppSettings["UserID"],
				password = ConfigurationManager.AppSettings["Password"],
				emailRecipient = emailrecipicent,
				emailSender = ConfigurationManager.AppSettings["CompanyEmail"]
			};

			var msg = new MailMessage();
			msg.To.Add(new MailAddress(email.emailRecipient));
			msg.From = new MailAddress(email.emailSender);
			msg.IsBodyHtml = true;

			msg.Subject = emailSubject;
			msg.Body = template;

			var client = new SmtpClient();
			client.Host = "smtp.gmail.com";
			client.Port = 587;
			client.UseDefaultCredentials = false;
			client.Credentials = new NetworkCredential(email.userId, email.password);
			client.EnableSsl = true;
			client.DeliveryMethod = SmtpDeliveryMethod.Network;

			client.Send(msg);
			msg.Dispose();
			client.Dispose();
		}
	}
}