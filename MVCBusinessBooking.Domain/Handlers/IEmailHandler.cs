using System.Net.Mail;

namespace MVCBusinessBooking.Domain.Handlers
{
	public interface IEmailHandler
	{
		Email email { get; set; }

		MailMessage msg { get; set; }

		void CreateEmailMessage(string emailSubject);

		string Mailbuilder();
	}
}